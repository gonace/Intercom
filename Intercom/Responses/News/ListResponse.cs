using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.News
{
    public class ListResponse : PageableResponse<Models.News>
    {
        [JsonProperty("data")]
        public override IEnumerable<Models.News> Data { get; set; }
    }
}
