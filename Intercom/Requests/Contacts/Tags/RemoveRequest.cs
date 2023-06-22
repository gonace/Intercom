using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Tags
{
    public class RemoveRequest : PlainRequest
    {
        public string ContactId { get; }
        public string TagId { get; }

        public RemoveRequest(Contact contact, Tag tag)
        {
            ContactId = contact.Id;
            TagId = tag.Id;
        }

        public RemoveRequest(string contactId, string tagId)
        {
            ContactId = contactId;
            TagId = tagId;
        }

        public override string Uri => $"contacts/{ContactId}/tags/{TagId}";
    }
}
