using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IArticlesClient
    {
    }

    public class ArticlesClient : BaseClient<ArticlesClient>, IArticlesClient
    {
        public ArticlesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
