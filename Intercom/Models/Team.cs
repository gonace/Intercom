using Intercom.Abstractions;
using Intercom.Models.Teams;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// Teams are groups of admins in Intercom.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-team-model">Documentation</see>
    /// </summary>
    public class Team : Model
    {
        /// <summary>
        /// The name of the team
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The list of admin IDs that are a part of the team.
        /// </summary>
        [JsonProperty("admin_ids")]
        public int[] AdminIds { get; set; }
        /// <summary>
        /// Admin priority levels for the team.
        /// </summary>
        [JsonProperty("admin_priority_level")]
        public PriorityLevel PriorityLevel { get; set; }
    }
}
