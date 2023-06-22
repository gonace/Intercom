using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Contacts.Subscriptions;
using Intercom.Responses.Subscriptions;
using System.Threading.Tasks;

namespace Intercom.Clients.Contacts
{
    public interface ISubscriptionClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);

        Subscription Add(AddRequest request);
        Task<Subscription> AddAsync(AddRequest request);
        Subscription Remove(RemoveRequest request);
        Task<Subscription> RemoveAsync(RemoveRequest request);
    }

    internal class SubscriptionsClient : BaseClient<SubscriptionsClient>, ISubscriptionClient
    {
        public SubscriptionsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SubscriptionsClient(string baseUri, string bearerToken)
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

        public Subscription Add(AddRequest request)
        {
            return Post<Subscription, AddRequest>(request);
        }

        public async Task<Subscription> AddAsync(AddRequest request)
        {
            return await PostAsync<Subscription, AddRequest>(request);
        }

        public Subscription Remove(RemoveRequest request)
        {
            return Delete<Subscription>(request);
        }

        public async Task<Subscription> RemoveAsync(RemoveRequest request)
        {
            return await DeleteAsync<Subscription>(request);
        }
    }
}
