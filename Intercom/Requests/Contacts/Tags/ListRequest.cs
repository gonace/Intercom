using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Tags
{
    /// <summary>
    /// You can fetch a list of all tags that are attached to a specific contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listtagsforacontact">Documentation</see>
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

        public override string Uri => $"contacts/{Id}/tags";
    }
}
