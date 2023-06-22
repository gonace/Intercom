using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Subscriptions
{
    public class AddRequest : PayloadRequest
    {
        public string ContactId { get; }
        public Subscription Subscription { get; }

        public AddRequest(Contact contact, Subscription subscription)
        {
            ContactId = contact.Id;
            Subscription = subscription;
        }

        public AddRequest(string contactId, Subscription subscription)
        {
            ContactId = contactId;
            Subscription = subscription;
        }

        public override object Payload => new
        {
            id = Subscription.Id,
            consent_type = Subscription.ConsentType
        };

        public override string Uri => $"contacts/{ContactId}/subscriptions";
    }
}
