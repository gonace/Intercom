using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Notes
{
    /// <summary>
    /// You can fetch a list of notes that are associated to a contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listnotes">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier of a contact.
        /// </summary>
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
