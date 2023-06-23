using Intercom.Abstractions;
using Intercom.Requests.Conversations.Tags;
using Intercom.Responses.Conversations.Tags;
using System.Threading.Tasks;

namespace Intercom.Clients.Conversations
{
    public interface ITagsClient
    {
        AttachResponse Add(AttachRequest request);
        Task<AttachResponse> AddAsync(AttachRequest request);
        DetachResponse Remove(DetachRequest request);
        Task<DetachResponse> RemoveAsync(DetachRequest request);
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

        public AttachResponse Add(AttachRequest request)
        {
            return Post<AttachResponse, AttachRequest>(request);
        }

        public async Task<AttachResponse> AddAsync(AttachRequest request)
        {
            return await PostAsync<AttachResponse, AttachRequest>(request);
        }

        public DetachResponse Remove(DetachRequest request)
        {
            return Delete<DetachResponse>(request);
        }

        public async Task<DetachResponse> RemoveAsync(DetachRequest request)
        {
            return await DeleteAsync<DetachResponse>(request);
        }
    }
}
