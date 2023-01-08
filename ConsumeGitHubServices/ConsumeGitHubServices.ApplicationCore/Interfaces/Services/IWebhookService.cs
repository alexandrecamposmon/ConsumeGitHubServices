using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Services
{
    public interface IWebhookService
    {
        public WebhookResponse WebhookCreate(WebhookRequest request, string User, string Repo);
        public WebhookResponse WebhookUpdate(WebhookRequest request, string User, string Repo, int id);
        public WebhookResponse WebhookGetById(string User, string Repo, int id);
        public IEnumerable<WebhookResponse> WebhookListByRepository(string User, string Repo);
    }
}
