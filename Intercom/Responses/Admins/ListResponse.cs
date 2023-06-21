using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Admins
{
    public class ListResponse : ListResponse<Admin>
    {
        [JsonProperty("data")]
        public override IEnumerable<Admin> Data { get; set; }
    }
}
