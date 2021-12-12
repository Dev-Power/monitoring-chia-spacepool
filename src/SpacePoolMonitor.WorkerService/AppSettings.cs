using System.Text;

namespace SpacePoolMonitor.WorkerService;

public class AppSettings
{
    public string LauncherId { get; set; } 
    public string ApiKey { get; set; }
    public string UserAgent { get; set; }
    public int CheckIntervalInMinutes { get; set; } = 30;

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"LauncherId: {LauncherId}");
        sb.AppendLine($"ApiKey: {ApiKey}");
        sb.AppendLine($"UserAgent: {UserAgent}");
        sb.AppendLine($"CheckIntervalInMinutes: {CheckIntervalInMinutes}");
        return sb.ToString();
    }
}