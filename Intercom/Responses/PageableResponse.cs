using Intercom.Models.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses
{
    public class PageableResponse<TResponse, TResult>
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("pages")]
        public Pages Pages { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        [JsonProperty("limited")]
        public bool Limited { get; set; }

        [JsonProperty(nameof(TResult))]
        public IEnumerable<TResponse> Result { get; set; } = new List<TResponse>();
    }
}
