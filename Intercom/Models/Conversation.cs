using Intercom.Abstractions;
using Intercom.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// Conversations are how you can communicate with users in Intercom.
    /// They are created when a contact replies to an outbound message, or when one admin
    /// directly sends a message to a single contact.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-conversation-model">Documentation</see>
    /// </summary>
    public class Conversation : Model
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("waiting_since")]
        public int WaitingSince { get; set; }
        [JsonProperty("snoozed_until")]
        public int SnoozedUntil { get; set; }
        [JsonProperty("open")]
        public bool Open { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("read")]
        public bool Read { get; set; }
        [JsonProperty("priority")]
        public string Priority { get; set; }
        [JsonProperty("admin_assignee_id")]
        public int AdminAssigneeId { get; set; }
        [JsonProperty("team_assignee_id")]
        public string TeamAssigneeId { get; set; }

        public IEnumerable<Segment> Segments { get; set; }
        [JsonConverter(typeof(TagsConverter))]
        [JsonProperty("tags")]
        public IEnumerable<Tag> Tags { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
