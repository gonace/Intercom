using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Segments
{
    public class ListResponse : ListResponse<Segment>
    {
        [JsonProperty("segments")]
        public override IEnumerable<Segment> Data { get; set; }
    }
}
