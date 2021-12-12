using System.Threading.Tasks;

namespace SpacePoolMonitor.EmailService;

public interface IEmailService
{
    Task SendNotification(string notificationMessage);
}