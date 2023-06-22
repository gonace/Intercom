using Intercom.Abstractions;
using Intercom.Requests.Subscriptions;
using Intercom.Responses.Subscriptions;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ISubscriptionsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
    }

    public class SubscriptionsClient : BaseClient<SubscriptionsClient>, ISubscriptionsClient
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
    }
}
