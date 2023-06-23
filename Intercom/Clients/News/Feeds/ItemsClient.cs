using Intercom.Abstractions;
using Intercom.Requests.News.Feeds.Items;
using Intercom.Responses.News.Feeds.Items;
using System.Threading.Tasks;

namespace Intercom.Clients.News.Feeds
{
    public interface IItemsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
    }

    internal class ItemsClient : BaseClient<ItemsClient>, IItemsClient
    {
        public ItemsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ItemsClient(string baseUri, string bearerToken)
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
    }
}
