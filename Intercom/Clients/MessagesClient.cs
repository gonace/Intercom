using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface IMessagesClient
    {
    }

    public class MessagesClient : BaseClient<MessagesClient>, IMessagesClient
    {
        public MessagesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public MessagesClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
        }
    }
}
