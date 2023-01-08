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

        [HttpGet("BranchsListByRepository/{User}/{Repo}")]
        public IEnumerable<BranchResponse> BranchsListByRepository(string User, string Repo)
        {
            var result = this.branchService.BranchsListByRepository(User, Repo);

            return result;
        }
    }
}