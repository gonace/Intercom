using Intercom.Abstractions;
using Intercom.Constants;
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
        public FeedsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
            Items = new Feeds.ItemsClient(url, bearerToken, version);
        }

        public FeedsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
            Items = new Feeds.ItemsClient(url, bearerToken);
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
