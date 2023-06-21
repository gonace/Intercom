using Newtonsoft.Json;

namespace Intercom.Models.Conversations
{
    public class Statistics
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("time_to_assignment")]
        public int TimeToAssignment { get; set; }
        [JsonProperty("time_to_admin_reply")]
        public int TimeToAdminReply { get; set; }
        [JsonProperty("time_to_first_close")]
        public int TimeToFirstClose { get; set; }
        [JsonProperty("time_to_last_close")]
        public int TimeToLastClose { get; set; }
        [JsonProperty("median_time_to_reply")]
        public int MedianTimeToReply { get; set; }
        [JsonProperty("first_contact_reply_at")]
        public int FirstContactReplyAt { get; set; }
        [JsonProperty("first_assignment_at")]
        public int FirstAssignmentAt { get; set; }
        [JsonProperty("first_admin_reply_at")]
        public int FirstAdminReplyAt { get; set; }
        [JsonProperty("first_close_at")]
        public int FirstCloseAt { get; set; }
        [JsonProperty("last_assignment_at")]
        public int LastAssignmentAt { get; set; }
        [JsonProperty("last_assignment_admin_reply_at")]
        public int LastAssignmentAdminReplyAt { get; set; }
        [JsonProperty("last_contact_reply_at")]
        public int LastContactReplyAt { get; set; }
        [JsonProperty("last_admin_reply_at")]
        public int LastAdminReplyAt { get; set; }
        [JsonProperty("last_close_at")]
        public int LastCloseAt { get; set; }
        [JsonProperty("last_closed_by_id")]
        public string LastClosedById { get; set; }
        [JsonProperty("count_reopens")]
        public int CountReopens { get; set; }
        [JsonProperty("count_assignments")]
        public int CountAssignments { get; set; }
        [JsonProperty("count_conversation_parts")]
        public int CountConversationParts { get; set; }
    }
}
