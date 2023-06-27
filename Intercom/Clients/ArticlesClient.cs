using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Articles;
using Intercom.Responses.Articles;
using Intercom.Responses.Generic;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IArticlesClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Article Get(GetRequest request);
        Task<Article> GetAsync(GetRequest request);
        Article Create(CreateRequest request);
        Task<Article> CreateAsync(UpdateRequest request);
        Article Update(UpdateRequest request);
        Task<Article> UpdateAsync(UpdateRequest request);
        DeleteResponse Delete(DeleteRequest request);
        Task<DeleteResponse> DeleteAsync(DeleteRequest request);
    }

    public class ArticlesClient : BaseClient<ArticlesClient>, IArticlesClient
    {
        public ArticlesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public ArticlesClient(Url url, string bearerToken)
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

        public Article Get(GetRequest request)
        {
            return Get<Article>(request);
        }

        public async Task<Article> GetAsync(GetRequest request)
        {
            return await GetAsync<Article>(request);
        }

        public Article Create(CreateRequest request)
        {
            return Post<Article, CreateRequest>(request);
        }

        public async Task<Article> CreateAsync(UpdateRequest request)
        {
            return await PostAsync<Article, UpdateRequest>(request);
        }

        public Article Update(UpdateRequest request)
        {
            return Put<Article, UpdateRequest>(request);
        }

        public async Task<Article> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Article, UpdateRequest>(request);
        }

        public DeleteResponse Delete(DeleteRequest request)
        {
            return Delete<DeleteResponse>(request);
        }

        public async Task<DeleteResponse> DeleteAsync(DeleteRequest request)
        {
            return await DeleteAsync<DeleteResponse>(request);
        }
    }
}
