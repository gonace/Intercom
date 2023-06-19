using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models
{
    public class Admin : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
