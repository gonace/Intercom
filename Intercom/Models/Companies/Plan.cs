using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models.Companies
{
    public class Plan : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
