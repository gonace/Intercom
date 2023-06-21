using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface ISwitchClient
    {
    }

    public class SwitchClient : BaseClient<SwitchClient>, ISwitchClient
    {
        public SwitchClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SwitchClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
