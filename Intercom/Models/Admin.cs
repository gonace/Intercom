using Intercom.Abstractions;
using Intercom.Models.Embedded;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// Admins are the teammate accounts that have access to a workspace.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-admin-model">Documentation</see>
    /// </summary>
    public class Admin : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
        [JsonProperty("away_mode_enabled")]
        public bool? AwayModeEnabled { get; set; }
        [JsonProperty("away_mode_reassign")]
        public bool? AwayModeReassign { get; set; }
        [JsonProperty("has_inbox_seat")]
        public bool? HasInboxSeat { get; set; }
        [JsonProperty("team_ids")]
        public int[] TeamIds { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
        [JsonProperty("team_priority_level")]
        public TeamPriorityLevel TeamPriorityLevel { get; set; }
    }
}
