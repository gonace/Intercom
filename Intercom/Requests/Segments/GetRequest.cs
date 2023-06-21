using Intercom.Abstractions;

namespace Intercom.Requests.Segments
{
    public class GetRequest : PlainRequest
    {
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"segments/{Id}";
    }
}
