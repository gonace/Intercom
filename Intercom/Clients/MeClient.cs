using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Me;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IMeClient
    {
        Admin Get();
        Task<Admin> GetAsync();
    }

    public class MeClient : BaseClient<MeClient>, IMeClient
    {
        public MeClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public MeClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }

        public Admin Get()
        {
            var request = new GetRequest();
            return Get<Admin>(request);
        }

        public async Task<Admin> GetAsync()
        {
            var request = new GetRequest();
            return await GetAsync<Admin>(request);
        }
    }
}
