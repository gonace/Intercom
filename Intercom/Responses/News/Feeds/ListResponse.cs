using Intercom.Abstractions;
using Intercom.Models.News;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.News.Feeds
{
    public class ListResponse : PageableResponse<Feed>
    {
        [JsonProperty("data")]
        public override IEnumerable<Feed> Data { get; set; }
    }
}
