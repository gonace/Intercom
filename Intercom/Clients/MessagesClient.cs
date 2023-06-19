using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IMessagesClient
    {
    }

    public class MessagesClient : BaseClient<MessagesClient>, IMessagesClient
    {
        public MessagesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
