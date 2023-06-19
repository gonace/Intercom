using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ISubscriptionClient
    {

    }

    public class SubscriptionsClient : BaseClient<SubscriptionsClient>, ISubscriptionClient
    {
        public SubscriptionsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
