using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Contacts
{
    public class AttachRequest : PayloadRequest
    {
        public string ConversationId { get; }
        public string ContactId { get; }

        public AttachRequest(Conversation conversation, Contact contact)
        {
            ConversationId = conversation.Id;
            ContactId = contact.Id;
        }

        public AttachRequest(string conversationId, string contactId)
        {
            ConversationId = conversationId;
            ContactId = contactId;
        }

        public override object Payload => new
        {
        };

        public override string Uri => $"conversations/{ConversationId}/customers";
    }
}
