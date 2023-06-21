using Newtonsoft.Json;

namespace Intercom.Models.Conversations
{
    public class Rating
    {
        [JsonProperty("rating")]
        public int Value { get; set; }
        [JsonProperty("remark")]
        public string Remark { get; set; }
        [JsonProperty("contact")]
        public Contact Contact { get; set; }
        [JsonProperty("teammate")]
        public Contact Teammate { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
    }
}
