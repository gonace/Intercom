using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface INewsClient
    {
        News.IFeedsClient Feeds { get; }
        News.IItemsClient Items { get; }
    }

    public class NewsClient : BaseClient<NewsClient>, INewsClient
    {
        public NewsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
            Feeds = new News.FeedsClient(url, bearerToken, version);
            Items = new News.ItemsClient(url, bearerToken, version);
        }

        public NewsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
            Feeds = new News.FeedsClient(url, bearerToken);
            Items = new News.ItemsClient(url, bearerToken);
        }

        public News.IFeedsClient Feeds { get; }
        public News.IItemsClient Items { get; }
    }
}
