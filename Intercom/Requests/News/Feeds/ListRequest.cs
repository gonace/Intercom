using Intercom.Abstractions;

namespace Intercom.Requests.News.Feeds
{
    /// <summary>
    /// You can fetch a list of all news feeds.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listnewsitems">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "news/newsfeeds";
    }
}
