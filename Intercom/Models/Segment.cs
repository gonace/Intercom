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
        /// <summary>
        /// The name of the segment.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Type of the contact: contact (lead) or user.
        /// </summary>
        [JsonProperty("person_type")]
        public string PersonType { get; set; }
        /// <summary>
        /// The number of items in the user segment. It's returned when include_count=true is included in the request.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The time the segment was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The time the segment was updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
