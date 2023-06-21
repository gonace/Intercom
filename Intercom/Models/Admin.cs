using Intercom.Abstractions;
using Intercom.Models.Shared;
using Intercom.Models.Teams;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// Admins are the teammate accounts that have access to a workspace.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-admin-model">Documentation</see>
    /// </summary>
    public class Admin : Model
    {
        /// <summary>
        /// The name of the admin.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The email of the admin.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// The job title of the admin.
        /// </summary>
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
        /// <summary>
        /// Identifies if this admin is currently set in away mode.
        /// </summary>
        [JsonProperty("away_mode_enabled")]
        public bool? AwayModeEnabled { get; set; }
        /// <summary>
        /// Identifies if this admin is set to automatically reassign new conversations
        /// to the apps default inbox.
        /// </summary>
        [JsonProperty("away_mode_reassign")]
        public bool? AwayModeReassign { get; set; }
        /// <summary>
        /// Identifies if this admin has a paid inbox seat to restrict/allow features
        /// that require them.
        /// </summary>
        [JsonProperty("has_inbox_seat")]
        public bool? HasInboxSeat { get; set; }
        /// <summary>
        /// This object represents the avatar associated with the admin.
        /// </summary>
        [JsonProperty("team_ids")]
        public int[] TeamIds { get; set; }

        /// <summary>
        /// Image for the associated team or teammate
        /// </summary>
        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
        /// <summary>
        /// Admin priority levels for teams
        /// </summary>
        [JsonProperty("team_priority_level")]
        public PriorityLevel TeamPriorityLevel { get; set; }
    }
}
