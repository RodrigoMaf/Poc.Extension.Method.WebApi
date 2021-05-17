using Poc.Extension.Methods.Domain.Contracts;

namespace Poc.Extension.Methods.Domain.Interfaces
{
    public interface IEmailSender
    {
        void Send(EmailMessage email);
    }
}
