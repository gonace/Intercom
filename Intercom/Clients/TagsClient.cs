using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ITagsClient
    {
    }

    public class TagsClient : BaseClient<TagsClient>, ITagsClient
    {
        public TagsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
