using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Subscriptions
{
    public class RemoveRequest : PlainRequest
    {
        public string ContactId { get; }
        public string SubscriptionId { get; }

        public RemoveRequest(Contact contact, Subscription subscription)
        {
            ContactId = contact.Id;
            SubscriptionId = subscription.Id;
        }

        public RemoveRequest(string contactId, string subscriptionId)
        {
            ContactId = contactId;
            SubscriptionId = subscriptionId;
        }

        public override string Uri => $"contacts/{ContactId}/subscriptions/{SubscriptionId}";
    }
}
