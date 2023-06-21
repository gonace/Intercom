using Newtonsoft.Json;

namespace Intercom.Models.Conversations
{
    public class SlaApplied
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// The name of the SLA as given by the teammate when it was created
        /// </summary>
        [JsonProperty("sla_name")]
        public string Name { get; set; }
        /// <summary>
        /// SLA statuses
        /// </summary>
        /// <list type="bullet">
        /// <listheader>
        /// <term>status</term>
        /// <description>description</description>
        /// </listheader>
        /// <item>
        /// <term>hit</term>
        /// <description>If there’s at least one hit event in the underlying sla_events table, and no “missed” or “canceled” events for the conversation.</description>
        /// </item>
        /// <item>
        /// <term>missed</term>
        /// <description>If there are any missed sla_events for the conversation and no canceled events. If there’s even a single missed sla event, the status will always be missed. A missed status is not applied when the SLA expires, only the next time a teammate replies.</description>
        /// </item>
        /// <item>
        /// <term>active</term>
        /// <description>An SLA has been applied to a conversation, but has not yet been fulfilled. SLA status is active only if there are no “hit, “missed”, or “canceled” events.</description>
        /// </item>
        /// </list>
        [JsonProperty("sla_status")]
        public string Status { get; set; }
    }
}
