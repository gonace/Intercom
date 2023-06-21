using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.News;
using Intercom.Responses.News;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface INewsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        News Get(GetRequest request);
        Task<News> GetAsync(GetRequest request);
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public NewsClient(string baseUri, string bearerToken)
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

        public News Get(GetRequest request)
        {
            return Get<News>(request);
        }

        public async Task<News> GetAsync(GetRequest request)
        {
            return await GetAsync<News>(request);
        }
    }
}
