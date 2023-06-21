using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Admins;
using Intercom.Responses.Admins;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IAdminsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Admin Get(GetRequest request);
        Task<Admin> GetAsync(GetRequest request);
    }

    public class AdminsClient : BaseClient<AdminsClient>, IAdminsClient
    {
        public AdminsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public AdminsClient(string baseUri, string bearerToken)
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

        public Admin Get(GetRequest request)
        {
            return Get<Admin>(request);
        }

        public async Task<Admin> GetAsync(GetRequest request)
        {
            return await GetAsync<Admin>(request);
        }
    }
}
