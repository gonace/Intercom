using Intercom.Abstractions;

namespace Intercom.Requests.News.Items
{
    /// <summary>
    /// You can fetch the details of a single news item.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievenewsitem">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the news item which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"news/news_items/{Id}";
    }
}
