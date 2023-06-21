using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Abstractions
{
    public abstract class ListResponse<TResponse>
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        public abstract IEnumerable<TResponse> Data { get; set; }
    }
}
