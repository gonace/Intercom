using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Tickets;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ITicketsClient
    {
        Ticket Get(GetRequest request);
        Task<Ticket> GetAsync(GetRequest request);
    }

    public class TicketsClient : BaseClient<TicketsClient>, ITicketsClient
    {
        public TicketsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TicketsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public Ticket Get(GetRequest request)
        {
            return Get<Ticket>(request);
        }

        public async Task<Ticket> GetAsync(GetRequest request)
        {
            return await GetAsync<Ticket>(request);
        }
    }
}
