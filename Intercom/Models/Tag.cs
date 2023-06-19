using Intercom.Abstractions;
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
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
