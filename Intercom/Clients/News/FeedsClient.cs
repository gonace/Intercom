using Intercom.Abstractions;
using Intercom.Models.News;
using Intercom.Requests.News.Feeds;
using Intercom.Responses.News.Feeds;
using System.Threading.Tasks;

namespace Intercom.Clients.News
{
    public interface IFeedsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Feed Get(GetRequest request);
        Task<Feed> GetAsync(GetRequest request);

        Feeds.IItemsClient Items { get; }
    }

    internal class FeedsClient : BaseClient<FeedsClient>, IFeedsClient
    {
        public FeedsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
            Items = new Feeds.ItemsClient(baseUri, bearerToken, apiVersion);
        }

        public FeedsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
            Items = new Feeds.ItemsClient(baseUri, bearerToken);
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }
        public Feed Get(GetRequest request)
        {
            return Get<Feed>(request);
        }

        public async Task<Feed> GetAsync(GetRequest request)
        {
            return await GetAsync<Feed>(request);
        }

        public Feeds.IItemsClient Items { get; }
    }
}
