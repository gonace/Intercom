using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// Message are how you reach out to contacts in Intercom.
    /// They are created when an admin sends an outbound message to a contact.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-message-model">Documentation</see>
    /// </summary>
    public class Message : Model
    {
        /// <summary>
        /// The associated conversation_id
        /// </summary>
        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// The subject of the message. Only present if message_type: email.
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }
        /// <summary>
        /// The message body, which may contain HTML.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }
        /// <summary>
        /// The type of message that was sent. Can be email, inapp, facebook or twitter.
        /// </summary>
        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// The time the conversation was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
    }
}
