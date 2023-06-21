using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Companies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ICompaniesClient
    {
        IEnumerable<Company> Find(FindRequest request);
        Task<IEnumerable<Company>> FindAsync(FindRequest request);
        IEnumerable<Company> List(ListRequest request);
        Task<IEnumerable<Company>> ListAsync(ListRequest request);
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

        public IEnumerable<Company> Find(FindRequest request)
        {
            return Get<IEnumerable<Company>>(request);
        }

        public async Task<IEnumerable<Company>> FindAsync(FindRequest request)
        {
            return await GetAsync<IEnumerable<Company>>(request);
        }

        public IEnumerable<Company> List(ListRequest request)
        {
            return Get<IEnumerable<Company>>(request);
        }

        public async Task<IEnumerable<Company>> ListAsync(ListRequest request)
        {
            return await GetAsync<IEnumerable<Company>>(request);
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
