using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface ISwitchClient
    {
    }

    public class SwitchClient : BaseClient<SwitchClient>, ISwitchClient
    {
        public SwitchClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public SwitchClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
        }
    }
}
