using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    public class ArchiveRequest : PlainRequest
    {
        public string Id { get; }

        public ArchiveRequest(Contact contact)
        {
            Id = contact.Id;
        }

        public ArchiveRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts{Id}/archive";
    }
}
