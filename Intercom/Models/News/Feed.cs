using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models.News
{
    /// <summary>
    /// A news item can be assigned to multiple news feeds, use the news feed_assignments
    /// array on the news item model to assign a news item to a news feed through the
    /// news feed assignment model.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-newsfeed-model">Documentation</see>
    /// </summary>
    public class Feed : Model
    {
        /// <summary>
        /// The name of the news feed. This name will never be visible to your users.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Timestamp for when the news feed was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// Timestamp for when the news feed was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
