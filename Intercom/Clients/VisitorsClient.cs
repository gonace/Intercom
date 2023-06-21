using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Visitors;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IVisitorsClient
    {
        Visitor Get(GetRequest request);
        Task<Visitor> GetAsync(GetRequest request);
    }

    public class VisitorsClient : BaseClient<VisitorsClient>, IVisitorsClient
    {
        public VisitorsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public VisitorsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public Visitor Get(GetRequest request)
        {
            return Get<Visitor>(request);
        }

        public async Task<Visitor> GetAsync(GetRequest request)
        {
            return await GetAsync<Visitor>(request);
        }
    }
}
