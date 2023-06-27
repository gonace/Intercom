using Intercom.Abstractions;
using Intercom.Constants;
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
        public SubscriptionsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public SubscriptionsClient(Url url, string bearerToken)
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
    }
}
