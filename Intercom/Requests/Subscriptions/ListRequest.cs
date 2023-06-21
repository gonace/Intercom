using Intercom.Abstractions;

namespace Intercom.Requests.Subscriptions
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "subscription_types";
    }
}
