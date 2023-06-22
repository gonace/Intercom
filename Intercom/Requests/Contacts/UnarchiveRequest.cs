using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can unarchive a single contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/unarchivecontact">Documentation</see>
    /// </summary>
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

        public override string Uri => $"contacts/{Id}/unarchive";
    }
}
