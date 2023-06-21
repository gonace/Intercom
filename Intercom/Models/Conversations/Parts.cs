using Intercom.Abstractions;
using Intercom.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models.Conversations
{
    public class Parts
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// A list of Conversation Part objects for each part message in the conversation.
        /// This is only returned when Retrieving a Conversation, and ignored when Listing all Conversations.
        /// There is a limit of 500 parts.
        /// </summary>
        [JsonProperty("conversation_parts")]
        public IEnumerable<Item> Items { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class Item : Model
    {
        [JsonProperty("external_id")]
        public bool ExternalId { get; set; }

        [JsonProperty("assigned_to")]
        public int? AssignedTo { get; set; }
        [JsonProperty("attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }
        [JsonProperty("author")]
        public Reference Author { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
        [JsonProperty("notified_at")]
        public long? NotifiedAt { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
