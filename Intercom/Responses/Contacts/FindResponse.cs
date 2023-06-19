using Intercom.Attributes;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Contacts
{
    public class FindResponse : PageableResponse<Contact>
    {
        [JsonProperty("contacts")]
        public override IEnumerable<Contact> Result { get; set; }
    }
}
