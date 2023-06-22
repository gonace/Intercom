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

        AddResponse Attach(AttachRequest request);
        Task<AddResponse> AttachAsync(AttachRequest request);
        RemoveResponse Detach(DetachRequest request);
        Task<RemoveResponse> DetachAsync(DetachRequest request);
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

        public AddResponse Attach(AttachRequest request)
        {
            return Post<AddResponse, AttachRequest>(request);
        }

        public async Task<AddResponse> AttachAsync(AttachRequest request)
        {
            return await PostAsync<AddResponse, AttachRequest>(request);
        }

        public RemoveResponse Detach(DetachRequest request)
        {
            return Delete<RemoveResponse>(request);
        }

        public async Task<RemoveResponse> DetachAsync(DetachRequest request)
        {
            return await DeleteAsync<RemoveResponse>(request);
        }
    }
}
