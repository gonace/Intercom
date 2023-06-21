using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface IConversationsClient
    {
    }

    public class ConversationsClient : BaseClient<ConversationsClient>, IConversationsClient
    {
        public ConversationsClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ConversationsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
