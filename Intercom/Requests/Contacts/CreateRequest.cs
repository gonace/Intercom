using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    public class CreateRequest : PayloadRequest
    {
        public Contact Contact { get; }

        public CreateRequest(Contact contact)
        {
            Contact = contact;
        }

        public override object Payload => new
        {
            role = Contact.Role,
            external_id = Contact.ExternalId,
            email = Contact.Email,
            phone = Contact.Phone,
            name = Contact.Name,
            avatar = Contact.Avatar.Url,
            signed_up_at = Contact.SignedUpdAt,
            last_seen_at = Contact.LastSeenAt,
            owner_id = Contact.OwnerId,
            unsubscribed_from_emails = Contact.UnsubscribedFromEmails,
            custom_attributes = Contact.Attributes
        };

        public override string Uri => "contacts";
    }
}
