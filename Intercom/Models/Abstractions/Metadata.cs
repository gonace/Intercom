using Newtonsoft.Json;

namespace Intercom.Models.Abstractions
{
    public abstract class Metadata<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }
}
