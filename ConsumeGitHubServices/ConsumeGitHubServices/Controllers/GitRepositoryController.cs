using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
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

        [HttpGet()]
        public IEnumerable<RepositoryResponse> GetAll()
        {
            return null;
        }
    }
}