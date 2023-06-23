using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Responses.Conversations.Tags
{
    public class DetachResponse : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
