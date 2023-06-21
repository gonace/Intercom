using Newtonsoft.Json;

namespace Intercom.Models.Shared
{
    public class SocialProfiles
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
