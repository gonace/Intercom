using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Tags
{
    /// <summary>
    /// You can remove tag from a specific contact.
    /// This will return a tag object for the tag that was removed from the contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/detachtagfromcontact">Documentation</see>
    /// </summary>
    public class RemoveRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the tag which is given by Intercom.
        /// </summary>
        public string TagId { get; }

        public RemoveRequest(Contact contact, Tag tag)
        {
            Id = contact.Id;
            TagId = tag.Id;
        }

        public RemoveRequest(string id, string tagId)
        {
            Id = id;
            TagId = tagId;
        }

        public override string Uri => $"contacts/{Id}/tags/{TagId}";
    }
}
