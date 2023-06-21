using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ISubscriptionClient
    {

    }

    public class SubscriptionsClient : BaseClient<SubscriptionsClient>, ISubscriptionClient
    {
        public SubscriptionsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SubscriptionsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
