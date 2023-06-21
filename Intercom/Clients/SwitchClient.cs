using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ISwitchClient
    {
    }

    public class SwitchClient : BaseClient<SwitchClient>, ISwitchClient
    {
        public SwitchClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SwitchClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
