using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Services
{
    public interface IBranchService
    {
        public IEnumerable<BranchResponse> BranchsListByRepository(string User, string Repo);

    }
}
