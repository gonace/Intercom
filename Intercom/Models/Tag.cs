using Intercom.Abstractions;
using Intercom.Models.Shared;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// A tag allows you to label your contacts and companies and list them using that tag.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-tag-model">Documentation</see>
    /// </summary>
    public class Tag : Model
    {
        /// <summary>
        /// The name of the tag.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The time when the tag was applied to the object.
        /// </summary>
        [JsonProperty("applied_at")]
        public long? AppliedAt { get; set; }
        /// <summary>
        /// Reference to another object.
        /// </summary>
        [JsonProperty("applied_by")]
        public Reference AppliedBy { get; set; }
    }
}
