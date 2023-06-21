using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Requests.Contacts;
using Intercom.Responses.Contacts;
using System;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IContactsClient
    {
        FindResponse Find(FindRequest request);
        Task<FindResponse> FindAsync(FindRequest request);
        FindResponse List(ListRequest request);
        Task<FindResponse> ListAsync(ListRequest request);
    }

    public class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(string baseUri, string bearerToken, Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ContactsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, ApiVersion.Latest)
        {
        }

        public FindResponse Find(FindRequest request)
        {
            return Post<FindResponse, FindRequest>(request);
        }

        public async Task<FindResponse> FindAsync(FindRequest request)
        {
            return await PostAsync<FindResponse, FindRequest>(request);
        }

        public FindResponse List(ListRequest request)
        {
            return Get<FindResponse>(request);
        }

        public async Task<FindResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<FindResponse>(request);
        }
    }
}
