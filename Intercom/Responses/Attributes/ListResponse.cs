using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Attributes
{
    public class ListResponse : ListResponse<Attribute>
    {
        [JsonProperty("data")]
        public override IEnumerable<Attribute> Data { get; set; }
    }
}
