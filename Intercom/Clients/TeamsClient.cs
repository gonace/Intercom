using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface ITeamsClient
    {
    }

    public class TeamsClient : BaseClient<TeamsClient>, ITeamsClient
    {
        public TeamsClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TeamsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
