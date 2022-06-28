using System.Threading.Tasks;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string message);
}
