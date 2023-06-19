using Intercom.Abstractions;
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
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
