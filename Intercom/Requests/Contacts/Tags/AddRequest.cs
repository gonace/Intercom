using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Tags
{
    public class AddRequest : PayloadRequest
    {
        public string ContactId { get; }
        public Tag Tag { get; }

        public AddRequest(Contact contact, Tag tag)
        {
            ContactId = contact.Id;
            Tag = tag;
        }

        public AddRequest(string contactId, Tag tag)
        {
            ContactId = contactId;
            Tag = tag;
        }

        public override object Payload => new
        {
            id = Tag.Id
        };

        public override string Uri => $"contacts/{ContactId}/tags";
    }
}
