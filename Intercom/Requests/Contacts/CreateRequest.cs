using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

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
        /// to Intercom.
        /// </summary>
        public string ExternalId { get; }
        /// <summary>
        /// The contacts email.
        /// </summary>
        public string Email { get; }
        /// <summary>
        /// The contacts phone.
        /// </summary>
        public string Phone { get; }
        /// <summary>
        /// The contacts name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// An image URL containing the avatar of a contact.
        /// </summary>
        public string Avatar { get; }
        /// <summary>
        /// The time specified for when a contact signed up.
        /// </summary>
        public long? SignedUpAt { get; }
        /// <summary>
        /// The time when the contact was last seen (either where
        /// the Intercom Messenger was installed or when specified manually).
        /// </summary>
        public long? LastSeenAt { get; }
        /// <summary>
        /// The id of an admin that has been assigned account ownership.
        /// of the contact
        /// </summary>
        public int OwnerId { get; }
        /// <summary>
        /// Whether the contact is unsubscribed from emails.
        /// </summary>
        public bool? UnsubscribedFromEmails { get; }
        /// <summary>
        /// The custom attributes which are set for the contact.
        /// </summary>
        public Dictionary<string, object> Attributes { get; set; }

        public CreateRequest(Contact contact)
        {
            Role = contact.Role;
            ExternalId = contact.ExternalId;
            Email = contact.Email;
            Phone = contact.Phone;
            Name = contact.Name;
            Avatar = contact.Avatar.Url;
            SignedUpAt = contact.SignedUpdAt;
            LastSeenAt = contact.LastSeenAt;
            OwnerId = contact.OwnerId;
            UnsubscribedFromEmails = contact.UnsubscribedFromEmails;
            Attributes = contact.Attributes;
        }

        public override object Payload => new
        {
            role = Role,
            external_id = ExternalId,
            email = Email,
            phone = Phone,
            name = Name,
            avatar = Avatar,
            signed_up_at = SignedUpAt,
            last_seen_at = LastSeenAt,
            owner_id = OwnerId,
            unsubscribed_from_emails = UnsubscribedFromEmails,
            custom_attributes = Attributes
        };

        public override string Uri => "contacts";
    }
}
