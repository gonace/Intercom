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

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
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
