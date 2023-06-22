using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using Type = Intercom.Models.Tickets.Type;

namespace Intercom.Responses.Tickets.Types
{
    public class ListResponse : PageableResponse<Type>
    {
        [JsonProperty("data")]
        public override IEnumerable<Type> Data { get; set; }
    }
}
