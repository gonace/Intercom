using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Teams
{
    public class ListResponse : ListResponse<Team>
    {
        [JsonProperty("teams")]
        public override IEnumerable<Team> Data { get; set; }
    }
}
