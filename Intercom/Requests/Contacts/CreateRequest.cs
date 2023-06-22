using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can create a new contact (ie. user or lead).
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The role of the contact.
        /// </summary>
        public string Role { get; }
        /// <summary>
        /// A unique identifier for the contact which is given
        /// to Intercom
        /// </summary>
        public string ExternalId { get; }
        /// <summary>
        /// The contacts email.
        /// </summary>
        public string Email { get; }

        public CreateRequest(Contact contact)
        {
            Role = contact.Role;
            ExternalId = contact.ExternalId;
        }

        public override object Payload => new
        {
            role = Role,
            external_id = ExternalId,
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
