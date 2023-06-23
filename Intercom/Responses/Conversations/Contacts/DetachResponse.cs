using Intercom.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Conversations.Contacts
{
    public class DetachResponse
    {
        [JsonProperty("customers")]
        public IEnumerable<Reference> Data { get; set; }
    }
}
