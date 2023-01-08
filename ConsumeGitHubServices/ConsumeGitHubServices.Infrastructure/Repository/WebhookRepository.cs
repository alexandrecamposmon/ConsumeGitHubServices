using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.Infrastructure.Repository
{
    public class WebhookRepository : IWebhookRepository
    {
        public WebhookResponse WebhookCreate(WebhookRequest request, string User, string Repo)
        {
            throw new NotImplementedException();
        }

        public WebhookResponse WebhookGetById(string User, string Repo, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebhookResponse> WebhookListByRepository(string User, string Repo)
        {
            throw new NotImplementedException();
        }

        public WebhookResponse WebhookUpdate(WebhookRequest request, string User, string Repo, int id)
        {
            throw new NotImplementedException();
        }
    }
}
