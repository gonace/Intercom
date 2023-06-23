using Intercom.Abstractions;
using Intercom.Models.News;

namespace Intercom.Requests.News.Feeds.Items
{
    /// <summary>
    /// You can fetch a list of all news items that are live on a given news feed.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listnewsitems">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the news feed item which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public ListRequest(Feed feed)
        {
            Id = feed.Id;
        }

        public ListRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"news/newsfeeds/{Id}/items";
    }
}
