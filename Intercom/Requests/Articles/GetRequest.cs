using Intercom.Abstractions;

namespace Intercom.Requests.Articles
{
    /// <summary>
    /// You can fetch the details of a single article by making a GET
    /// request to https://api.intercom.io/articles/<id>.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievearticle">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the article which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"articles/{Id}";
    }
}
