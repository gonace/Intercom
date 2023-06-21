using Intercom.Abstractions;

namespace Intercom.Requests.Conversations
{
    public class GetRequest : PlainRequest
    {
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"conversations/{Id}";
    }
}
