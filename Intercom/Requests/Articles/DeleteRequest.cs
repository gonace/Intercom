using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Articles
{
    public class DeleteRequest : PlainRequest
    {
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
