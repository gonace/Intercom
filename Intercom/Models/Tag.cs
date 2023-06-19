using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models
{
    public class Tag : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
