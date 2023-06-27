using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models.News;
using Intercom.Requests.News.Items;
using Intercom.Responses.News.Items;
using System.Threading.Tasks;

namespace Intercom.Clients.News
{
    public interface IItemsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Item Get(GetRequest request);
        Task<Item> GetAsync(GetRequest request);
    }

    internal class ItemsClient : BaseClient<ItemsClient>, IItemsClient
    {
        public ItemsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public ItemsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
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

        public Item Get(GetRequest request)
        {
            return Get<Item>(request);
        }

        public async Task<Item> GetAsync(GetRequest request)
        {
            return await GetAsync<Item>(request);
        }
    }
}
