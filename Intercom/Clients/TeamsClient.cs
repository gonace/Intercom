using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ITeamsClient
    {
    }

    public class TeamsClient : BaseClient<TeamsClient>, ITeamsClient
    {
        public TeamsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TeamsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
