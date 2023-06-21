using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Subscriptions
{
    public class ListResponse : ListResponse<Subscription>
    {
        [JsonProperty("data")]
        public override IEnumerable<Subscription> Data { get; set; }
    }
}
