using Newtonsoft.Json;

namespace Intercom.Models.Subscriptions
{
    public class Translation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}
