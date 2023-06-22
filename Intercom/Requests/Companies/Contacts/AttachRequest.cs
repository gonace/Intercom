using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Companies.Contacts
{
    /// <summary>
    /// You can attach a company to a single contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/attachcontacttoacompany">Documentation</see>
    /// </summary>
    public class AttachRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the company which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string ContactId { get; }

        public AttachRequest(Company company, Contact contact)
        {
            Id = company.Id;
            ContactId = contact.Id;
        }

        public AttachRequest(string id, string contactId)
        {
            Id = id;
            ContactId = contactId;
        }

        public override object Payload => new
        {
            id = Id
        };

        public override string Uri => $"contacts/{ContactId}/companies";
    }
}
