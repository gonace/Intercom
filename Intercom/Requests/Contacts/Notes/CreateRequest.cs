using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Notes
{
    /// <summary>
    /// You can add a note to a single contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createnote">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier of a given contact.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The text of the note.
        /// </summary>
        public string Body { get; }
        /// <summary>
        /// The unique identifier of a given admin.
        /// </summary>
        public string AdminId { get; }

        public CreateRequest(Contact contact, Note note)
        {
            Id = contact.Id;
            Body = note.Body;
            AdminId = note.Author.Id;
        }

        public CreateRequest(string id, string body, string adminId = null)
        {
            Id = id;
            Body = body;
            AdminId = adminId;
        }

        public override object Payload => new
        {
            body = Body,
            admin_id = AdminId
        };

        public override string Uri => $"contacts/{Id}/notes";
    }
}
