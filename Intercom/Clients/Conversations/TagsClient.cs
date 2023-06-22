using Intercom.Abstractions;
using Intercom.Requests.Conversations.Tags;
using Intercom.Responses.Conversations.Tags;
using System.Threading.Tasks;

namespace Intercom.Clients.Conversations
{
    public interface ITagsClient
    {
        AddResponse Add(AddRequest request);
        Task<AddResponse> AddAsync(AddRequest request);
        RemoveResponse Remove(RemoveRequest request);
        Task<RemoveResponse> RemoveAsync(RemoveRequest request);
    }

    internal class TagsClient : BaseClient<TagsClient>, ITagsClient
    {
        public TagsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TagsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public AddResponse Add(AddRequest request)
        {
            return Post<AddResponse, AddRequest>(request);
        }

        public async Task<AddResponse> AddAsync(AddRequest request)
        {
            return await PostAsync<AddResponse, AddRequest>(request);
        }

        public RemoveResponse Remove(RemoveRequest request)
        {
            return Delete<RemoveResponse>(request);
        }

        public async Task<RemoveResponse> RemoveAsync(RemoveRequest request)
        {
            return await DeleteAsync<RemoveResponse>(request);
        }
    }
}
