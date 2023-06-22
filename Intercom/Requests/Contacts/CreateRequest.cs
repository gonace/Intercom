using Intercom.Abstractions;
using Intercom.Extensions;
using Intercom.Models;
using System;
using System.Collections.Generic;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can create a new contact (ie. user or lead).
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createcontact">Documentation</see>
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
        public long? LastSeenAt { get; protected set; }
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
            OwnerId = contact.OwnerId;
            UnsubscribedFromEmails = contact.UnsubscribedFromEmails;
            Attributes = contact.Attributes;
        }

        public CreateRequest(string role, string externalId, string email, string phone, string name, string avatar, long? signedUpAt, int ownerId, bool? unsubscribedFromEmails, Dictionary<string, object> attributes)
        {
            Role = role;
            ExternalId = externalId;
            Email = email;
            Phone = phone;
            Name = name;
            Avatar = avatar;
            SignedUpAt = signedUpAt;
            OwnerId = ownerId;
            UnsubscribedFromEmails = unsubscribedFromEmails;
            Attributes = attributes;
        }

        public CreateRequest SetLastSeenAt()
        {
            LastSeenAt = DateTime.Now.ToUnixTimestamp();

            return this;
        }

        public CreateRequest SetLastSeenAt(long timestamp)
        {
            LastSeenAt = timestamp;

            return this;
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
