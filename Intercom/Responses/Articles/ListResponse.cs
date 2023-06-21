using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Articles
{
    public class ListResponse : PageableResponse<Article>
    {
        [JsonProperty("data")]
        public override IEnumerable<Article> Data { get; set; }
    }
}
