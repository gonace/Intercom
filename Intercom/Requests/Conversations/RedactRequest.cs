using Intercom.Abstractions;

namespace Intercom.Requests.Conversations
{
    /// <summary>
    /// You can redact a conversation part or the source message of a conversation (as seen in the source object).
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/redactconversation">Documentation</see>
    /// </summary>
    public class RedactRequest : PayloadRequest
    {
        /// <summary>
        /// The type of resource being redacted.
        /// </summary>
        public string Type { get; }
        /// <summary>
        /// The id of the conversation.
        /// </summary>
        public string ConversationId { get; }
        /// <summary>
        /// The id of the conversation_part.
        /// </summary>
        public string PartId { get; }

        public RedactRequest(string type, string conversationId, string partId)
        {
            Type = type;
            ConversationId = conversationId;
            PartId = partId;
        }

        public override object Payload => new
        {
            type = Type,
            conversation_id = ConversationId,
            conversation_part_id = PartId
        };

        public override string Uri => $"conversations/redact";
    }
}
