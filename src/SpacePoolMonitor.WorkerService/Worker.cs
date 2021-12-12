using Microsoft.Extensions.Options;
using SpacePoolMonitor.ApiClient.Api;
using SpacePoolMonitor.ApiClient.Model;
using SpacePoolMonitor.EmailService;

namespace SpacePoolMonitor.WorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly AppSettings _settings;
    private readonly IEmailService _emailService;

    public Worker(ILogger<Worker> logger, AppSettings settings, IEmailService emailService)
    {
        _logger = logger;
        _settings = settings;
        _emailService = emailService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        string launcherId = _settings.LauncherId;
        string apiKey = _settings.ApiKey;
        string userAgent = _settings.UserAgent;
        int interval = _settings.CheckIntervalInMinutes;
        
        _logger.LogInformation($"Worker started with the following:\n{_settings}");
        
        while (!stoppingToken.IsCancellationRequested)
        {
            GetFarmPartialsV1Api apiClient = new GetFarmPartialsV1Api();
            PartialV1ModelCollectionResponseV1Model response = await apiClient.ApiV1FarmsLauncherIdOrAliasPartialsGetAsync(launcherId, apiKey, userAgent, stoppingToken);
            
            PartialV1Model? latestSuccessfulSubmission = response.Results
                .OrderByDescending(r => r.SubmissionDateTimeUtc)
                .FirstOrDefault(r => r.State.Description == "Verified");
            
            if (latestSuccessfulSubmission == null)
            {
                var message = "No verified partials received";
                _logger.LogError(message);
                await _emailService.SendNotification(message);
                return;
            }
            
            TimeSpan timeElapsedSinceLastVerifiedPartial =
                DateTime.UtcNow - DateTime.Parse(latestSuccessfulSubmission.SubmissionDateTimeUtc);
            
            if (timeElapsedSinceLastVerifiedPartial.TotalMinutes >= interval)
            {
                var message = $"No verified partials in the last {interval} minutes";
                _logger.LogError(message);
                await _emailService.SendNotification(message);
            }
            else
            {
                _logger.LogInformation($"Last verified partial received {Math.Floor(timeElapsedSinceLastVerifiedPartial.TotalMinutes)} minutes ago. All looking good.");
            }
            
            
            await Task.Delay(interval * 60 * 1000, stoppingToken);
        }
    }
}