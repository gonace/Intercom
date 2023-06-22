using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    public class UnarchiveRequest : PlainRequest
    {
        public string Id { get; }

        public UnarchiveRequest(Contact contact)
        {
            Id = contact.Id;
        }

        public UnarchiveRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts{Id}/unarchive";
    }
}
