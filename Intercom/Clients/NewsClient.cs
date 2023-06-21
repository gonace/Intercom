using Intercom.Abstractions;
using Intercom.Constants;
using System;

namespace Intercom.Clients
{
    public interface INewsClient
    {
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(string baseUri, string bearerToken, Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public NewsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, ApiVersion.Latest)
        {
        }
    }
}
