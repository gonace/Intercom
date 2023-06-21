using Intercom.Abstractions;
using Intercom.Constants;
using System;

namespace Intercom.Clients
{
    public interface ISubscriptionClient
    {

    }

    public class SubscriptionsClient : BaseClient<SubscriptionsClient>, ISubscriptionClient
    {
        public SubscriptionsClient(string baseUri, string bearerToken, Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SubscriptionsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, ApiVersion.Latest)
        {
        }
    }
}
