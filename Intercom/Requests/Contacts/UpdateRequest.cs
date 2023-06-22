using Intercom.Abstractions;
using Intercom.Extensions;
using Intercom.Models;
using System;
using System.Collections.Generic;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can update an existing contact (ie. user or lead).
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/updatecontact">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        public string Id { get; }
        /// <summary>
        /// The role of the contact.
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// A unique identifier for the contact which is given
        /// to Intercom.
        /// </summary>
        public string ExternalId { get; set; }
        /// <summary>
        /// The contacts email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The contacts phone.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// The contacts name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// An image URL containing the avatar of a contact.
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// The time specified for when a contact signed up.
        /// </summary>
        public long? SignedUpAt { get; set; }
        /// <summary>
        /// The time when the contact was last seen (either where
        /// the Intercom Messenger was installed or when specified manually).
        /// </summary>
        public long? LastSeenAt { get; protected set; }
        /// <summary>
        /// The id of an admin that has been assigned account ownership.
        /// of the contact
        /// </summary>
        public int OwnerId { get; set; }
        /// <summary>
        /// Whether the contact is unsubscribed from emails.
        /// </summary>
        public bool? UnsubscribedFromEmails { get; set; }
        /// <summary>
        /// The custom attributes which are set for the contact.
        /// </summary>
        public Dictionary<string, object> Attributes { get; set; }


        public UpdateRequest(Contact contact)
        {
            Id = contact.Id;
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

        public UpdateRequest(string id)
        {
            Id = id;
        }

        public UpdateRequest SetLastSeenAt()
        {
            LastSeenAt = DateTime.Now.ToUnixTimestamp();

            return this;
        }

        public UpdateRequest SetLastSeenAt(long timestamp)
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

        public override string Uri => $"contacts/{Id}";
    }
}
