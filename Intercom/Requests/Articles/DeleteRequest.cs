using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Articles
{
    /// <summary>
    /// You can delete a single article by making a DELETE
    /// request to https://api.intercom.io/articles/<id>.
    /// </summary>
    public class DeleteRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the article which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public DeleteRequest(Article article)
        {
            Id = article.Id;
        }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"articles/{Id}";
    }
}
