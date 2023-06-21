using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Contacts;
using Intercom.Responses.Contacts;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IContactsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Contact Get(GetRequest request);
        Task<Contact> GetAsync(GetRequest request);
    }

    public class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ContactsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Contact Get(GetRequest request)
        {
            return Get<Contact>(request);
        }

        public async Task<Contact> GetAsync(GetRequest request)
        {
            return await GetAsync<Contact>(request);
        }
    }
}
