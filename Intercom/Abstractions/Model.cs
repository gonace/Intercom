using Newtonsoft.Json;

namespace Intercom.Abstractions
{
    public abstract class Model
    {
        /// <summary>
        /// The id representing the object.
        /// </summary>
        [JsonProperty("id")]
        public virtual string Id { get; set; }
        /// <summary>
        /// String representing the object's type.
        /// </summary>
        [JsonProperty("type")]
        public virtual string Type { get; set; }
    }
}
