using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Tags
{
    public class ListResponse : ListResponse<Tag>
    {
        [JsonProperty("data")]
        public override IEnumerable<Tag> Data { get; set; }
    }
}
