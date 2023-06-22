using Newtonsoft.Json;

namespace Intercom.Responses.Generic
{
    public class ArchiveResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }
        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }
}
