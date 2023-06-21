using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ITagsClient
    {
    }

    public class TagsClient : BaseClient<TagsClient>, ITagsClient
    {
        public TagsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TagsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
