using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Subscriptions
{
    /// <summary>
    /// You can add a specific subscription to a contact.
    /// This will return a subscription type model for the subscription type that was added to the contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/attachsubscriptiontypetocontact">Documentation</see>
    /// </summary>
    public class AddRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the subscription which is given by Intercom.
        /// </summary>
        public string SubscriptionId { get; }
        /// <summary>
        /// The consent_type of a subscription, opt_out or opt_in.
        /// </summary>
        public string ConsentType { get; }

        public AddRequest(Contact contact, Subscription subscription)
        {
            Id = contact.Id;
            SubscriptionId = subscription.Id;
            ConsentType = subscription.ConsentType;
        }

        public AddRequest(string id, string subscriptionId, string consentType)
        {
            Id = id;
            SubscriptionId = subscriptionId;
            ConsentType = consentType;
        }

        public override object Payload => new
        {
            id = SubscriptionId,
            consent_type = ConsentType
        };

        public override string Uri => $"contacts/{Id}/subscriptions";
    }
}
