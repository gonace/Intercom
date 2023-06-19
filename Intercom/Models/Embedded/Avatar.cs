using Newtonsoft.Json;

namespace Intercom.Models.Embedded
{
    public class Avatar
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("image_url")]
        public string Url { get; set; }
    }
}
