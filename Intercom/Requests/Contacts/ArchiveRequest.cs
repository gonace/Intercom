using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can archive a single contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/archivecontact">Documentation</see>
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
