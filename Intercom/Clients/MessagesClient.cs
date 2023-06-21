using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IMessagesClient
    {
    }

    public class MessagesClient : BaseClient<MessagesClient>, IMessagesClient
    {
        public MessagesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public MessagesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
