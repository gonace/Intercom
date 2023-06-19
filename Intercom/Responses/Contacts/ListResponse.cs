using Intercom.Attributes;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Contacts
{
    public class ListResponse : PageableResponse<Contact>
    {
        [JsonProperty("contacts")]
        public override IEnumerable<Contact> Result { get; set; }
    }
}
