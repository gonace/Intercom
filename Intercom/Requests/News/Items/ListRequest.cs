using Intercom.Abstractions;

namespace Intercom.Requests.News.Items
{
    /// <summary>
    /// You can fetch a list of all news items.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listnewsitems">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "news/news_items";
    }
}
