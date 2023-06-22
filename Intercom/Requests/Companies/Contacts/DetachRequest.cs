using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Companies.Contacts
{
    public class DetachRequest : PlainRequest
    {
        public string CompanyId { get; }
        public string ContactId { get; }

        public DetachRequest(Company company, Contact contact)
        {
            CompanyId = company.Id;
            ContactId = contact.Id;
        }

        public DetachRequest(string companyId, string contactId)
        {
            CompanyId = companyId;
            ContactId = contactId;
        }

        public override string Uri => $"contacts/{ContactId}/companies/{CompanyId}";
    }
}
