using Newtonsoft.Json;

namespace Intercom.Responses.Generic
{
    public class DeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}
