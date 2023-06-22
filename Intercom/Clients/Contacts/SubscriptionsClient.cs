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

        Subscription Attach(AttachRequest request);
        Task<Subscription> AttachAsync(AttachRequest request);
        Subscription Detach(DetachRequest request);
        Task<Subscription> DetachAsync(DetachRequest request);
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

        public Subscription Attach(AttachRequest request)
        {
            return Post<Subscription, AttachRequest>(request);
        }

        public async Task<Subscription> AttachAsync(AttachRequest request)
        {
            return await PostAsync<Subscription, AttachRequest>(request);
        }

        public Subscription Detach(DetachRequest request)
        {
            return Delete<Subscription>(request);
        }

        public async Task<Subscription> DetachAsync(DetachRequest request)
        {
            return await DeleteAsync<Subscription>(request);
        }
    }
}
