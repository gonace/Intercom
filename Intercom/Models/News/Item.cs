using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models.News
{
    /// <summary>
    /// The News API allows you to easily manage news items and news feeds.
    /// News are shared through news items which can be assigned to multiple news feeds.
    /// A news feed is a collection of news items, targeted to a specific audience.
    /// News feeds currently cannot be edited through the API, please refer to this article to set up your news feeds in Intercom.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-news-item-newsfeed-models">Documentation</see>
    /// </summary>
    public class Item : Model
    {
        /// <summary>
        /// The id of the sender of the news item. Must be a teammate on the workspace.
        /// </summary>
        [JsonProperty("sender_id")]
        public int SenderId { get; set; }
        /// <summary>
        /// The id of the workspace which the news item belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The title of the news item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// The news item body, which may contain HTML.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }
        /// <summary>
        /// News items will not be visible to your users in the assigned news feeds until they are set live.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// 	URL of the image used as cover. Must have .jpg or .png extension.
        /// </summary>
        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }
        /// <summary>
        /// When set to true, the news item will appear in the messenger news feed without showing a notification badge.
        /// </summary>
        [JsonProperty("deliver_silently")]
        public bool DeliverSilently { get; set; }
        //TODO: Implement typing
        [JsonProperty("newsfeed_assignments")]
        public dynamic NewsfeedAssignments { get; set; }
        //TODO: Implement typing
        [JsonProperty("labels")]
        public dynamic Labels { get; set; }
        //TODO: Implement typing
        [JsonProperty("reactions")]
        public dynamic Reactions { get; set; }

        /// <summary>
        ///	Timestamp for when the news item was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// Timestamp for when the news item was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
