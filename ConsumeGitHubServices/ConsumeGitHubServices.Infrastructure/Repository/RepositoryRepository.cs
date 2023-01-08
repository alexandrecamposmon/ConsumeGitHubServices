using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Newtonsoft.Json;

namespace ConsumeGitHubServices.Infrastructure.Repository
{
    public class RepositoryRepository : IRepositoryRepository
    {
        public RepositoryResponse RepositoryCreate(RepositoryRequest request)
        {

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RepositoryResponse>> RepositoryListAll(string User)
        {
            try
            {
                using (var cliente = new HttpClient())
                {
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    var response = await cliente.GetAsync("https://api.github.com/users/alexandrecamposmon/repos");

                    var result = await response.Content.ReadAsStringAsync();
                    var teste = result;
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
