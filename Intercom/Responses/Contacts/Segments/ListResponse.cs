using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Contacts.Segments
{
    public class ListResponse : ListResponse<Segment>
    {
        [JsonProperty("data")]
        public override IEnumerable<Segment> Data { get; set; }
    }
}
