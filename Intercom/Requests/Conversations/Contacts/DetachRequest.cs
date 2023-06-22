using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Contacts
{
    public class DetachRequest : PayloadRequest
    {
        public string ConversationId { get; }
        public string ContactId { get; }
        public string AdminId { get; set; }

        public DetachRequest(Conversation conversation, Contact contact)
        {
            ConversationId = conversation.Id;
            ContactId = contact.Id;
        }

        public DetachRequest(string conversationId, string contactId)
        {
            ConversationId = conversationId;
            ContactId = contactId;
        }

        public override object Payload => new
        {
            admin_id = AdminId
        };

        public override string Uri => $"conversations/{ConversationId}/customers/{ContactId}";
    }
}
