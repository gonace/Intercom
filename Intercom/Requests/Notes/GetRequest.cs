using Intercom.Abstractions;

namespace Intercom.Requests.Notes
{
    public class GetRequest : PlainRequest
    {
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"notes/{Id}";
    }
}
