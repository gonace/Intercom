using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface INewsClient
    {
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
