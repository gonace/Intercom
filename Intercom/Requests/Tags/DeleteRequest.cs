using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Tags
{
    public class DeleteRequest : PlainRequest
    {
        public string Id { get; }

        public DeleteRequest(Tag tag)
        {
            Id = tag.Id;
        }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"tags/{Id}";
    }
}
