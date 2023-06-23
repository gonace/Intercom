using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Responses.Conversations.Tags
{
    public class AttachResponse : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
