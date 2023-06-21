using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Events
{
    public class ListResponse : ListResponse<Event>
    {
        [JsonProperty("events")]
        public override IEnumerable<Event> Data { get; set; }
    }
}
