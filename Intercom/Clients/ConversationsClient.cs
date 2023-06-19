using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IConversationsClient
    {
    }

    public class ConversationsClient : BaseClient<ConversationsClient>, IConversationsClient
    {
        public ConversationsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
