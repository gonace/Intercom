using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Conversations
{
    public class ListResponse : PageableResponse<Article>
    {
        [JsonProperty("conversations")]
        public override IEnumerable<Article> Data { get; set; }
    }
}
