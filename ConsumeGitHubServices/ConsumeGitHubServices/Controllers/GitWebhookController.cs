using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeGitHubServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitWebhookController : ControllerBase
    {
        private readonly IWebhookService webhookService;
        public GitWebhookController(IWebhookService webhookService)
        {
            this.webhookService = webhookService;
        }

        [HttpGet("WebhookGetById/{User}/{Repo}/{id}")]
        public WebhookResponse WebhookGetById(string User, string Repo, int id)
        {
            var result = this.webhookService.WebhookGetById(User, Repo, id);

            return result;
        }

        [HttpGet("WebhookListByRepository/{User}/{Repo}")]
        public IEnumerable<WebhookResponse> WebhookListByRepository(string User, string Repo)
        {
            var result = this.webhookService.WebhookListByRepository(User, Repo);

            return result;
        }

        [HttpPost("WebhookCreate/{User}/{Repo}")]
        public WebhookResponse WebhookCreate([FromBody]WebhookRequest request, [FromQuery] string User, string Repo)
        {
            var result = webhookService.WebhookCreate(request, User, Repo);

            return result;
        }

        [HttpPut("WebhookUpdate/{User}/{Repo}/{id}")]
        public WebhookResponse WebhookUpdate([FromBody]WebhookRequest request, [FromQuery] string User, string Repo, int id)
        {
            var result = webhookService.WebhookUpdate(request, User, Repo, id);

            return result;
        }
    }
}