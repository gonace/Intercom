using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can archive a single contact.
    /// </summary>
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
