using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Tags
{
    public class RemoveRequest : PlainRequest
    {
        public string ConversationId { get; }
        public string TagId { get; }

        public RemoveRequest(Conversation conversation, Tag tag)
        {
            ConversationId = conversation.Id;
            TagId = tag.Id;
        }

        public RemoveRequest(string conversationId, string tagId)
        {
            ConversationId = conversationId;
            TagId = tagId;
        }

        public override string Uri => $"conversations/{ConversationId}/tags/{TagId}";
    }
}
