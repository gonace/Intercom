using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    public class GetRequest : PlainRequest
    {
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts/{Id}";
    }
}
