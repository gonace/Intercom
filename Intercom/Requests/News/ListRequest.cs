using Intercom.Abstractions;

namespace Intercom.Requests.News
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "news/news_items";
    }
}
