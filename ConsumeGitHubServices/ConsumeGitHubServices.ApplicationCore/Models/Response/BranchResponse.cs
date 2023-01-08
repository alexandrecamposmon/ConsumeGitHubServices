using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Response
{
    public class BranchResponse
    {
        public string Name { get; set; }
        public Commit Commit { get; set; }
        public bool Protected { get; set; }
    }
    public class Commit
    {
        public string Sha { get; set; }
        public string Url { get; set; }
    }
}
