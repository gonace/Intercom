using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface ISubscriptionClient
    {

    }

    public class SubscriptionsClient : BaseClient<SubscriptionsClient>, ISubscriptionClient
    {
        public SubscriptionsClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SubscriptionsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
