using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Contacts
{
    /// <summary>
    /// You can add participants who are contacts to a conversation, on behalf of either another contact or an admin.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/detachcontactfromconversation">Documentation</see>
    /// </summary>
    public class DetachRequest : PayloadRequest
    {
        /// <summary>
        /// The identifier for the conversation as given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The identifier for the contact as given by Intercom.
        /// </summary>
        public string ContactId { get; }
        /// <summary>
        /// The id of the admin who is performing the action.
        /// </summary>
        public string AdminId { get; set; }

        public DetachRequest(Conversation conversation, Contact contact)
        {
            Id = conversation.Id;
            ContactId = contact.Id;
        }

        public DetachRequest(string id, string contactId)
        {
            Id = id;
            ContactId = contactId;
        }

        public override object Payload => new
        {
            admin_id = AdminId
        };

        public override string Uri => $"conversations/{Id}/customers/{ContactId}";
    }
}
