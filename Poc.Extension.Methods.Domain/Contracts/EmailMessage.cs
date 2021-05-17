using System.Collections.Generic;
using System.IO;

namespace Poc.Extension.Methods.Domain.Contracts
{
    public class EmailMessage
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public string To { get; set; }

        public string CC { get; set; }

        public string CCO { get; set; }

        public Dictionary<string, Stream> Attachments { get; set; }
    }
}
