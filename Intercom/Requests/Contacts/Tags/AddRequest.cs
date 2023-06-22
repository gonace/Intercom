using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Tags
{
    /// <summary>
    /// You can tag a specific contact.
    /// This will return a tag object for the tag that was added to the contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/attachtagtocontact">Documentation</see>
    /// </summary>
    public class AddRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string TagId { get; }

        public AddRequest(Contact contact, Tag tag)
        {
            Id = contact.Id;
            TagId = tag.Id;
        }

        public AddRequest(string id, string tagId)
        {
            Id = id;
            TagId = tagId;
        }

        public override object Payload => new
        {
            id = TagId
        };

        public override string Uri => $"contacts/{Id}/tags";
    }
}
