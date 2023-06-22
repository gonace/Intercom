using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    public class DeleteRequest : PlainRequest
    {
        public string Id { get; set; }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts/{Id}";
    }
}
