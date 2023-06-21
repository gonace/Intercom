using Intercom.Abstractions;

namespace Intercom.Requests.Articles
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "articles";
    }
}
