using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Teams;
using Intercom.Responses.Teams;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ITeamsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Team Get(GetRequest request);
        Task<Team> GetAsync(GetRequest request);
    }

    public class TeamsClient : BaseClient<TeamsClient>, ITeamsClient
    {
        public TeamsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public TeamsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
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

        public Team Get(GetRequest request)
        {
            return Get<Team>(request);
        }

        public async Task<Team> GetAsync(GetRequest request)
        {
            return await GetAsync<Team>(request);
        }
    }
}
