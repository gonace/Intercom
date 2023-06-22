using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Companies.Contacts
{
    public class AttachRequest : PayloadRequest
    {
        public string CompanyId { get; }
        public string ContactId { get; }

        public AttachRequest(Company company, Contact contact)
        {
            CompanyId = company.Id;
            ContactId = contact.Id;
        }

        public AttachRequest(string companyId, string contactId)
        {
            CompanyId = companyId;
            ContactId = contactId;
        }

        public override object Payload => new
        {
            id = CompanyId
        };

        public override string Uri => $"contacts/{ContactId}/companies";
    }
}
