using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface INewsClient
    {
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public NewsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
