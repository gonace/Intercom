using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Articles;
using Intercom.Responses.Articles;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IArticlesClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Article Get(GetRequest request);
        Task<Article> GetAsync(GetRequest request);
    }

    public class ArticlesClient : BaseClient<ArticlesClient>, IArticlesClient
    {
        public ArticlesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ArticlesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Article Get(GetRequest request)
        {
            return Get<Article>(request);
        }

        public async Task<Article> GetAsync(GetRequest request)
        {
            return await GetAsync<Article>(request);
        }
    }
}
