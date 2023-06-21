using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface INewsClient
    {
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public NewsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
