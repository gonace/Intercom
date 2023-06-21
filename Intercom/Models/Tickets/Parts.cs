using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models.Tickets
{
    public class Parts
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("ticket_parts")]
        public IEnumerable<Item> Items { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class Item : Model
    {
    }
}
