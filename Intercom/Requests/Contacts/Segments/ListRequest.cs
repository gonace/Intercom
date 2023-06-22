using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Segments
{
    /// <summary>
    /// You can fetch a list of segments that are associated to a contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listsegmentsforacontact">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
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

        public override string Uri => $"contacts/{Id}/segments";
    }
}
