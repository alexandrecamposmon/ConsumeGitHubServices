using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.Infrastructure.Repository
{
    public class BranchRepository : IBranchRepository
    {
        public IEnumerable<BranchResponse> BranchsListByRepository(string User, string Repo)
        {
            throw new NotImplementedException();
        }
    }
}
