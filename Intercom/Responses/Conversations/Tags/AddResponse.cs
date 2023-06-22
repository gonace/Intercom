using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Responses.Conversations.Tags
{
    public class AddResponse : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
