using Intercom.Abstractions;
using Intercom.Models.News;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.News.Items
{
    public class ListResponse : PageableResponse<Item>
    {
        [JsonProperty("data")]
        public override IEnumerable<Item> Data { get; set; }
    }
}
