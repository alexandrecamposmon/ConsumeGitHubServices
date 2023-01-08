using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeGitHubServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitRepositoryController : ControllerBase
    {

        private readonly IRepositoryService repositoryService;
        public GitRepositoryController(IRepositoryService repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet("RepositoryListAll/{User}")]
        public async Task<IEnumerable<RepositoryResponse>> RepositoryListAll(string User)
        {
            var result = await this.repositoryService.RepositoryListAll(User);

            return result;
        }

        [HttpPost("RepositoryCreate")]
        public RepositoryResponse RepositoryCreate(RepositoryRequest request)
        {
            var result = this.repositoryService.RepositoryCreate(request);

            return result;
        }
    }
}