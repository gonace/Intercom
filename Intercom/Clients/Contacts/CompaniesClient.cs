using Intercom.Abstractions;
using Intercom.Requests.Contacts.Companies;
using Intercom.Responses.Companies;
using System.Threading.Tasks;

namespace Intercom.Clients.Contacts
{
    public interface ICompaniesClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
    }

    internal class CompaniesClient : BaseClient<CompaniesClient>, ICompaniesClient
    {
        public CompaniesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public CompaniesClient(string baseUri, string bearerToken)
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
    }
}
