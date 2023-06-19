using Newtonsoft.Json;

namespace Intercom.Abstractions
{
    public abstract class Model
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Id { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Type { get; set; }
    }
}
