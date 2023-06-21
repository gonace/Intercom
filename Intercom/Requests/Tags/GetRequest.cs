using Intercom.Abstractions;

namespace Intercom.Requests.Tags
{
    public class GetRequest : PlainRequest
    {
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"tags/{Id}";
    }
}
