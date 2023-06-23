using Intercom.Abstractions;
using Intercom.Requests.Contacts.Tags;
using Intercom.Responses.Contacts.Tags;
using Intercom.Responses.Tags;
using System.Threading.Tasks;

namespace Intercom.Clients.Contacts
{
    public interface ITagsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);

        AttachResponse Attach(AttachRequest request);
        Task<AttachResponse> AttachAsync(AttachRequest request);
        DetachResponse Detach(DetachRequest request);
        Task<DetachResponse> DetachAsync(DetachRequest request);
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

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public AttachResponse Attach(AttachRequest request)
        {
            return Post<AttachResponse, AttachRequest>(request);
        }

        public async Task<AttachResponse> AttachAsync(AttachRequest request)
        {
            return await PostAsync<AttachResponse, AttachRequest>(request);
        }

        public DetachResponse Detach(DetachRequest request)
        {
            return Delete<DetachResponse>(request);
        }

        public async Task<DetachResponse> DetachAsync(DetachRequest request)
        {
            return await DeleteAsync<DetachResponse>(request);
        }
    }
}
