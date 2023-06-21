using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Companies
{
    public class ListResponse : PageableResponse<Company>
    {
        [JsonProperty("data")]
        public override IEnumerable<Company> Data { get; set; }
    }
}
