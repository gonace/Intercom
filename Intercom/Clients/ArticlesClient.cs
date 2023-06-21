using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IArticlesClient
    {
    }

    public class ArticlesClient : BaseClient<ArticlesClient>, IArticlesClient
    {
        public ArticlesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ArticlesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
