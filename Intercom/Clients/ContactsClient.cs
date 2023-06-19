using Intercom.Abstractions;
using Intercom.Internals;
using Intercom.Models;
using Intercom.Requests.Contacts;
using Intercom.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IContactsClient
    {
        PageableResponse<IEnumerable<Contact>, Contacts> Find(FindRequest request);
        Task<PageableResponse<IEnumerable<Contact>, Contacts>> FindAsync(FindRequest request);
        PageableResponse<IEnumerable<Contact>, Contacts> List(ListRequest request);
        Task<PageableResponse<IEnumerable<Contact>, Contacts>> ListAsync(ListRequest request);
    }

    public class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }

        public PageableResponse<IEnumerable<Contact>, Contacts> Find(FindRequest request)
        {
            return Post<PageableResponse<IEnumerable<Contact>, Contacts>, FindRequest>(request);
        }

        public async Task<PageableResponse<IEnumerable<Contact>, Contacts>> FindAsync(FindRequest request)
        {
            return await PostAsync<PageableResponse<IEnumerable<Contact>, Contacts>, FindRequest>(request);
        }

        public PageableResponse<IEnumerable<Contact>, Contacts> List(ListRequest request)
        {
            return Get<PageableResponse<IEnumerable<Contact>, Contacts>>(request);
        }

        public async Task<PageableResponse<IEnumerable<Contact>, Contacts>> ListAsync(ListRequest request)
        {
            return await GetAsync<PageableResponse<IEnumerable<Contact>, Contacts>>(request);
        }
    }
}
