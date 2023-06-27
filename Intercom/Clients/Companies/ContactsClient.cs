using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Companies.Contacts;
using Intercom.Responses.Contacts;
using System.Threading.Tasks;

namespace Intercom.Clients.Companies
{
    public interface IContactsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Company Attach(AttachRequest request);
        Task<Company> AttachAsync(AttachRequest request);
        Company Detach(DetachRequest request);
        Task<Company> DetachAsync(DetachRequest request);

        Contacts.ICompaniesClient Companies { get; }
    }

    internal class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
            Companies = new Contacts.CompaniesClient(url, bearerToken, version);
        }

        public ContactsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
            Companies = new Contacts.CompaniesClient(url, bearerToken);
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Company Attach(AttachRequest request)
        {
            return Post<Company, AttachRequest>(request);
        }

        public async Task<Company> AttachAsync(AttachRequest request)
        {
            return await PostAsync<Company, AttachRequest>(request);
        }

        public Company Detach(DetachRequest request)
        {
            return Delete<Company>(request);
        }

        public async Task<Company> DetachAsync(DetachRequest request)
        {
            return await DeleteAsync<Company>(request);
        }

        public Contacts.ICompaniesClient Companies { get; }
    }
}
