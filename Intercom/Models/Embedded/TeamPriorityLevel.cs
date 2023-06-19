using Newtonsoft.Json;

namespace Intercom.Models.Embedded
{
    public class TeamPriorityLevel
    {
        [JsonProperty("primary_team_ids")]
        public int[] PrimaryTeamIds { get; set; }
        [JsonProperty("secondary_team_ids")]
        public int[] SecondaryTeamIds { get; set; }
    }
}
