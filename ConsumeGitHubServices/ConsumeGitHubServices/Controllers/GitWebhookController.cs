using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
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

        [HttpGet()]
        public IEnumerable<WebhookResponse> GetAll()
        {
            return null;
        }
    }
}