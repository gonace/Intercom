using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations
{
    public class UpdateRequest : PayloadRequest
    {
        public Conversation Conversation { get; }

        public UpdateRequest(Conversation conversation)
        {
            Conversation = conversation;
        }

        public override object Payload => new
        {
            read = Conversation.Read,
            custom_attributes = Conversation.Attributes
        };

        public override string Uri => $"conversations/{Conversation.Id}";
    }
}
