using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Contacts
{
    /// <summary>
    /// You can add participants who are contacts to a conversation, on behalf of either another contact or an admin.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/attachcontacttoconversation">Documentation</see>
    /// </summary>
    public class AttachRequest : PayloadRequest
    {
        /// <summary>
        /// The identifier for the conversation as given by Intercom.
        /// </summary>
        public string Id { get; }
        public string ContactId { get; }

        public AttachRequest(Conversation conversation, Contact contact)
        {
            Id = conversation.Id;
            ContactId = contact.Id;
        }

        public AttachRequest(string conversationId, string contactId)
        {
            Id = conversationId;
            ContactId = contactId;
        }

        //TODO: Fix payload
        public override object Payload => new
        {
        };

        public override string Uri => $"conversations/{Id}/customers";
    }
}
