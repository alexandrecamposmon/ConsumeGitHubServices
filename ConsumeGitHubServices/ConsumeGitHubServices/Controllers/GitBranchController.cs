using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeGitHubServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GitBranchController : ControllerBase
    {

        private readonly IBranchService branchService;
        public GitBranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        }

        [HttpGet()]
        public IEnumerable<BranchResponse> GetAll()
        {
            return null;
        }
    }
}