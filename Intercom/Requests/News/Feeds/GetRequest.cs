using Intercom.Abstractions;

namespace Intercom.Requests.News.Feeds
{
    /// <summary>
    /// You can fetch the details of a single news feed.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievenewsfeed">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the news feed item which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"news/newsfeeds/{Id}";
    }
}
