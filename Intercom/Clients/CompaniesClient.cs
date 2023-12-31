﻿using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Companies;
using Intercom.Responses.Companies;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ICompaniesClient
    {
        Company Find(FindRequest request);
        Task<Company> FindAsync(FindRequest request);
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Company Get(GetRequest request);
        Task<Company> GetAsync(GetRequest request);
        Company Upsert(UpsertRequest request);
        Task<Company> UpsertAsync(UpsertRequest request);
        Company Update(UpdateRequest request);
        Task<Company> UpdateAsync(UpdateRequest request);
        void Delete(DeleteRequest request);
        Task DeleteAsync(DeleteRequest request);

        Companies.IContactsClient Contacts { get; }
        Companies.ISegmentsClient Segments { get; }
    }

    public class CompaniesClient : BaseClient<CompaniesClient>, ICompaniesClient
    {
        public CompaniesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
            Contacts = new Companies.ContactsClient(url, bearerToken, version);
            Segments = new Companies.SegmentsClient(url, bearerToken, version);
        }

        public CompaniesClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
            Contacts = new Companies.ContactsClient(url, bearerToken);
            Segments = new Companies.SegmentsClient(url, bearerToken);
        }

        public Company Find(FindRequest request)
        {
            return Get<Company>(request);
        }

        public async Task<Company> FindAsync(FindRequest request)
        {
            return await GetAsync<Company>(request);
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
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

        public Companies.IContactsClient Contacts { get; }
        public Companies.ISegmentsClient Segments { get; }
    }
}
