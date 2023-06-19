using Intercom.Models.Embedded;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Attributes
{
    public abstract class PageableResponse<TResponse>
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("pages")]
        public Pages Pages { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        [JsonProperty("limited")]
        public bool Limited { get; set; }

        public abstract IEnumerable<TResponse> Result { get; set; }
    }
}
