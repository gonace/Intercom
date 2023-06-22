using Intercom.Abstractions;
using Intercom.Requests.Conversations.Tags;
using Intercom.Responses.Conversations.Tags;
using System.Threading.Tasks;

namespace Intercom.Clients.Conversations
{
    public interface ITagsClient
    {
        AddResponse Add(AttachRequest request);
        Task<AddResponse> AddAsync(AttachRequest request);
        RemoveResponse Remove(DetachRequest request);
        Task<RemoveResponse> RemoveAsync(DetachRequest request);
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

        public AddResponse Add(AttachRequest request)
        {
            return Post<AddResponse, AttachRequest>(request);
        }

        public async Task<AddResponse> AddAsync(AttachRequest request)
        {
            return await PostAsync<AddResponse, AttachRequest>(request);
        }

        public RemoveResponse Remove(DetachRequest request)
        {
            return Delete<RemoveResponse>(request);
        }

        public async Task<RemoveResponse> RemoveAsync(DetachRequest request)
        {
            return await DeleteAsync<RemoveResponse>(request);
        }
    }
}
