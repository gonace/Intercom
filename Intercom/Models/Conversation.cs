using Intercom.Abstractions;
using Intercom.Converters;
using Intercom.Models.Conversations;
using Intercom.Models.Shared;
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
        /// <summary>
        /// The title given to the conversation.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// The last time a Contact responded to an Admin. In other words, the time a customer started waiting for a response.
        /// Set to null if last reply is from an Admin.
        /// </summary>
        [JsonProperty("waiting_since")]
        public int WaitingSince { get; set; }
        /// <summary>
        /// If set this is the time in the future when this conversation will be marked as open. i.e. it will be in a snoozed state
        /// until this time. i.e. it will be in a snoozed state until this time.
        /// </summary>
        [JsonProperty("snoozed_until")]
        public int SnoozedUntil { get; set; }
        /// <summary>
        /// Indicates whether a conversation is open (true) or closed (false).
        /// </summary>
        [JsonProperty("open")]
        public bool Open { get; set; }
        /// <summary>
        /// Can be set to "open", "closed" or "snoozed".
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// Indicates whether a conversation has been read.
        /// </summary>
        [JsonProperty("read")]
        public bool Read { get; set; }
        /// <summary>
        /// If marked as priority, it will return priority or else not_priority.
        /// </summary>
        [JsonProperty("priority")]
        public string Priority { get; set; }
        /// <summary>
        /// The id of the admin assigned to the conversation. If it's not assigned to an admin it will return null.
        /// </summary>
        [JsonProperty("admin_assignee_id")]
        public int AdminAssigneeId { get; set; }
        /// <summary>
        /// The id of the team assigned to the conversation. If it's not assigned to a team it will return null.
        /// </summary>
        [JsonProperty("team_assignee_id")]
        public string TeamAssigneeId { get; set; }
        /// <summary>
        /// An object containing information on the first users message. For a contact initiated message this will represent
        /// the users original message.
        /// </summary>
        [JsonProperty("first_contact_reply")]
        public FirstContactReply FirstContactReply { get; set; }
        /// <summary>
        /// The SLA Applied object contains the details for which SLA has been applied to this conversation.
        /// Important: if there are any canceled sla_events for the conversation - meaning an SLA has been manually removed
        /// from a conversation, the sla_status will always be returned as null.
        /// </summary>
        [JsonProperty("sla_applied")]
        public SlaApplied SlaApplied { get; set; }
        /// <summary>
        /// A Statistics object containing all information required for reporting, with timestamps and calculated metrics.
        /// </summary>
        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }
        /// <summary>
        /// A list of Conversation Part objects for each part message in the conversation.
        /// This is only returned when Retrieving a Conversation, and ignored when Listing all Conversations.
        /// There is a limit of 500 parts.
        /// </summary>
        [JsonProperty("conversation_parts")]
        public Parts Parts { get; set; }

        /// <summary>
        /// A list of tags objects associated with a conversation
        /// </summary>
        public IEnumerable<Segment> Segments { get; set; }
        [JsonConverter(typeof(TagsConverter))]
        [JsonProperty("tags")]
        public IEnumerable<Tag> Tags { get; set; }
        /// <summary>
        /// The Conversation Rating object which contains information on the rating and/or remark added by a Contact and
        /// the Admin assigned to the conversation.
        /// </summary>
        [JsonProperty("conversation_rating")]
        public Rating Rating { get; set; }
        /// <summary>
        /// The Conversation Part that originated this conversation, which can be Contact, Admin, Campaign, Automated or
        /// Operator initiated.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }
        /// <summary>
        /// The list of contacts (users or leads) involved in this conversation. This will only contain one customer unless
        /// more were added via the group conversation feature.
        /// </summary>
        [JsonProperty("contacts")]
        public IEnumerable<Reference> Contacts { get; set; }
        /// <summary>
        /// The list of teammates who participated in the conversation (wrote at least one conversation part).
        /// </summary>
        [JsonProperty("tammates")]
        public IEnumerable<Reference> Teammates { get; set; }

        /// <summary>
        /// An object containing the different custom attributes associated to the conversation as key-value pairs.
        /// For relationship attributes the value will be a list of custom object instance models.
        /// </summary>
        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The time the conversation was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The last time the conversation was updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
