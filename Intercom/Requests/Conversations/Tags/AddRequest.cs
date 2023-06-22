using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Tags
{
    public class AddRequest : PayloadRequest
    {
        public string ConversationId { get; }
        public Tag Tag { get; }

        public AddRequest(Conversation conversation, Tag tag)
        {
            ConversationId = conversation.Id;
            Tag = tag;
        }

        public AddRequest(string conversation, Tag tag)
        {
            ConversationId = conversation;
            Tag = tag;
        }

        public override object Payload => new
        {
            id = Tag.Id
        };

        public override string Uri => $"conversations/{ConversationId}/tags";
    }
}
