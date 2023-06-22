using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Contacts.Notes
{
    public class ListResponse : ListResponse<Note>
    {
        [JsonProperty("data")]
        public override IEnumerable<Note> Data { get; set; }
    }
}
