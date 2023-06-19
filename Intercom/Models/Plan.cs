using Newtonsoft.Json;

namespace Intercom.Models
{
    public class Plan
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
