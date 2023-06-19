using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// A segment is a group of your contacts defined by rules that you set.
    /// Contacts are automatically added to the segment every time the contact updates to match those rules.
    /// You can use Search for contacts to find contacts that match the same rules.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-segment-model">Documentation</see>
    /// </summary>
    public class Segment : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("person_type")]
        public string PersonType { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
