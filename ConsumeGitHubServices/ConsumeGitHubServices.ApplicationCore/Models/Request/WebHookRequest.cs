using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Request
{
    public class WebhookRequest
    {
        public bool Active { get; set; }
        public List<string> Events { get; set; }
        public ConfigRequest ConfigRequest { get; set; }
    }
    public class ConfigRequest
    {
        public string Url { get; set; }
        public string ContentType { get; set; }
        public string InsecureSsl { get; set; }
    }
}
