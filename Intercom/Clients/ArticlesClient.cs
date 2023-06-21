using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface IArticlesClient
    {
    }

    public class ArticlesClient : BaseClient<ArticlesClient>, IArticlesClient
    {
        public ArticlesClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ArticlesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
