using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Admins;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IAdminsClient
    {
        IEnumerable<Admin> List(ListRequest request);
        Task<IEnumerable<Admin>> ListAsync(ListRequest request);
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

        public IEnumerable<Admin> List(ListRequest request)
        {
            return Get<IEnumerable<Admin>>(request);
        }

        public async Task<IEnumerable<Admin>> ListAsync(ListRequest request)
        {
            return await GetAsync<IEnumerable<Admin>>(request);
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
