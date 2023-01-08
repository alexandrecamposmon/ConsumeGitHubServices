using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Request
{
    public class WebHookRequest
    {
        public bool Active { get; set; }
        public List<string> Events { get; set; }
        public Config Config { get; set; }
    }
    public class Config
    {
        public string Url { get; set; }
        public string ContentType { get; set; }
        public string InsecureSsl { get; set; }
    }
}
