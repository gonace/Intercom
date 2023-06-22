using Intercom.Abstractions;
using Intercom.Models.Shared;
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
        [JsonProperty("part_type")]
        public string PartType { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("author")]
        public Author Author { get; set; }
        [JsonProperty("attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
