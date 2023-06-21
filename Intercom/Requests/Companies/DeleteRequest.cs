using Intercom.Abstractions;

namespace Intercom.Requests.Companies
{
    public class DeleteRequest : PlainRequest
    {
        public string Id { get; set; }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"companies/{Id}";
    }
}
