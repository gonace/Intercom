using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Tags;
using Intercom.Responses.Tags;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ITagsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Tag Get(GetRequest request);
        Task<Tag> GetAsync(GetRequest request);
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

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Tag Get(GetRequest request)
        {
            return Get<Tag>(request);
        }

        public async Task<Tag> GetAsync(GetRequest request)
        {
            return await GetAsync<Tag>(request);
        }
    }
}
