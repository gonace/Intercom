using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models.Tickets
{
    public class Contacts
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("contacts")]
        public IEnumerable<Contact> Items { get; set; }
    }
}
