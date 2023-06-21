using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Companies;
using Intercom.Responses.Companies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ICompaniesClient
    {
        IEnumerable<ListResponse> List(ListRequest request);
        Task<IEnumerable<ListResponse>> ListAsync(ListRequest request);
        Company Get(GetRequest request);
        Task<Company> GetAsync(GetRequest request);
        Company Upsert(UpsertRequest request);
        Task<Company> UpsertAsync(UpsertRequest request);
        Company Update(UpdateRequest request);
        Task<Company> UpdateAsync(UpdateRequest request);
        void Delete(DeleteRequest request);
        Task DeleteAsync(DeleteRequest request);
    }

    public class CompaniesClient : BaseClient<CompaniesClient>, ICompaniesClient
    {
        public CompaniesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public CompaniesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public IEnumerable<ListResponse> List(ListRequest request)
        {
            return Get<IEnumerable<ListResponse>>(request);
        }

        public async Task<IEnumerable<ListResponse>> ListAsync(ListRequest request)
        {
            return await GetAsync<IEnumerable<ListResponse>>(request);
        }

        public Company Get(GetRequest request)
        {
            return Get<Company>(request);
        }

        public async Task<Company> GetAsync(GetRequest request)
        {
            return await GetAsync<Company>(request);
        }

        public Company Upsert(UpsertRequest request)
        {
            return Post<Company, Company>(request);
        }

        public async Task<Company> UpsertAsync(UpsertRequest request)
        {
            return await PostAsync<Company, Company>(request);
        }

        public Company Update(UpdateRequest request)
        {
            return Put<Company, Company>(request);
        }

        public async Task<Company> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Company, Company>(request);
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
