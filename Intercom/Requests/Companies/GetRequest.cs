using Intercom.Abstractions;

namespace Intercom.Requests.Companies
{
    public class GetRequest : PlainRequest
    {
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"companies/{Id}";
    }
}
