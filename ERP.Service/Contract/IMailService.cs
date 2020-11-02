using ERP.Domain;
using System.Threading.Tasks;

namespace ERP.Service.Contract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
