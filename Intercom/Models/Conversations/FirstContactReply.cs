using Newtonsoft.Json;

namespace Intercom.Models.Conversations
{
    public class FirstContactReply
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
    }
}
