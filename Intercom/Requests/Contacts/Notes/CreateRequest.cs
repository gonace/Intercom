using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Notes
{
    public class CreateRequest : PayloadRequest
    {
        public string ContactId { get; }
        public Note Note { get; }

        public CreateRequest(Contact contact, Note note)
        {
            ContactId = contact.Id;
            Note = note;
        }

        public CreateRequest(string contactId, Note note)
        {
            ContactId = contactId;
            Note = note;
        }

        public override object Payload => new
        {
            body = Note.Body
        };

        public override string Uri => $"contacts/{ContactId}/notes";
    }
}
