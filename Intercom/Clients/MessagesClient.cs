using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface IMessagesClient
    {
    }

    public class MessagesClient : BaseClient<MessagesClient>, IMessagesClient
    {
        public MessagesClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public MessagesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
