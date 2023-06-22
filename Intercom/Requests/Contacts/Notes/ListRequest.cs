using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Notes
{
    public class ListRequest : PlainRequest
    {
        public string Id { get; }

        public ListRequest(Contact contact)
        {
            Id = contact.Id;
        }

        public ListRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts/{Id}/notes";
    }
}
