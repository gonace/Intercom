using Newtonsoft.Json;

namespace Intercom.Abstractions
{
    public abstract class Model
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }
        [JsonProperty("type")]
        public virtual string Type { get; set; }
    }
}
