using Intercom.Abstractions;

namespace Intercom.Requests.Articles
{
    /// <summary>
    /// You can fetch a list of all articles by making a GET
    /// request to https://api.intercom.io/articles.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listarticles">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "articles";
    }
}
