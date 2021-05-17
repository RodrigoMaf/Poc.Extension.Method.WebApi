using System.Collections.Generic;
using System.IO;
using Poc.Extension.Methods.Domain.Contracts;
using Poc.Extension.Methods.Domain.Interfaces;

namespace Poc.Extension.Methods.Infra.Extensions
{
    public static class EmailSenderExtensions
    {

        public static void Send(this IEmailSender email, string subject, string body, string to ) 
        {
            email.Send(new EmailMessage() { To = to, Subject = subject, Body = body } );
        }

        public static void Send(this IEmailSender email, string subject, string body, string to, Dictionary<string, Stream> att)
        {
            email.Send(new EmailMessage() { To = to, Subject = subject, Body = body, Attachments = att });
        }
    }
}
