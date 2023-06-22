using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Subscriptions
{
    /// <summary>
    /// You can remove a specific subscription from a contact.
    /// This will return a subscription type model for the subscription type that was removed from the contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/detachsubscriptiontypetocontact">Documentation</see>
    /// </summary>
    public class RemoveRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the subscription type which is given by Intercom.
        /// </summary>
        public string SubscriptionId { get; }

        public RemoveRequest(Contact contact, Subscription subscription)
        {
            Id = contact.Id;
            SubscriptionId = subscription.Id;
        }

        public RemoveRequest(string id, string subscriptionId)
        {
            Id = id;
            SubscriptionId = subscriptionId;
        }

        public override string Uri => $"contacts/{Id}/subscriptions/{SubscriptionId}";
    }
}
