using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface INewsClient
    {
        News.IFeedsClient Feeds { get; }
        News.IItemsClient Items { get; }
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
            Feeds = new News.FeedsClient(baseUri, bearerToken, apiVersion);
            Items = new News.ItemsClient(baseUri, bearerToken, apiVersion);
        }

        public NewsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
            Feeds = new News.FeedsClient(baseUri, bearerToken);
            Items = new News.ItemsClient(baseUri, bearerToken);
        }

        public News.IFeedsClient Feeds { get; }
        public News.IItemsClient Items { get; }
    }
}
