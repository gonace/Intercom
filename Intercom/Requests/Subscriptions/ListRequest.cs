using Intercom.Abstractions;

namespace Intercom.Requests.Subscriptions
{
    /// <summary>
    /// You can list all subscription types.
    /// A list of subscription type objects will be returned.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listsubscriptiontypes">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "subscription_types";
    }
}
