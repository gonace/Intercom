using Newtonsoft.Json;

namespace Intercom.Models.Teams
{
    public class PriorityLevel
    {
        /// <summary>
        /// The primary team ids for the team.
        /// </summary>
        [JsonProperty("primary_team_ids")]
        public int[] PrimaryTeamIds { get; set; }
        /// <summary>
        /// The secondary team ids for the team.
        /// </summary>
        [JsonProperty("secondary_team_ids")]
        public int[] SecondaryTeamIds { get; set; }
    }
}
