using Newtonsoft.Json;

namespace Intercom.Models.Shared
{
    public class Pages
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
