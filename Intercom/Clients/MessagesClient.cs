using Intercom.Abstractions;
using Intercom.Constants;
using System;

namespace Intercom.Clients
{
    public interface IMessagesClient
    {
    }

    public class MessagesClient : BaseClient<MessagesClient>, IMessagesClient
    {
        public MessagesClient(string baseUri, string bearerToken, Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public MessagesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, ApiVersion.Latest)
        {
        }
    }
}
