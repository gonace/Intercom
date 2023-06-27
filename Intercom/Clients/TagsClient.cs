using Intercom.Abstractions;
using Intercom.Constants;
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
        void Delete(DeleteRequest request);
        Task DeleteAsync(DeleteRequest request);
    }

    public class TagsClient : BaseClient<TagsClient>, ITagsClient
    {
        public TagsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public TagsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
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

        public void Delete(DeleteRequest request)
        {
            base.Delete(request);
        }

        public async Task DeleteAsync(DeleteRequest request)
        {
            await base.DeleteAsync(request);
        }
    }
}
