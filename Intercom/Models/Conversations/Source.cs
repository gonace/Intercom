using Intercom.Abstractions;
using Intercom.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models.Conversations
{
    public class Source : Model
    {
        [JsonProperty("delivered_as")]
        public string DeliveredAs { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }

        [JsonProperty("author")]
        public Reference Author { get; set; }
        [JsonProperty("attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }
    }
}
