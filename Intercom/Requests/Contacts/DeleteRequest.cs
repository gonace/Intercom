using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can delete a single contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/deletecontact">Documentation</see>
    /// </summary>
    public class DeleteRequest : PlainRequest
    {
        public string Id { get; set; }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts/{Id}";
    }
}
