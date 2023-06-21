﻿using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Contacts;
using Intercom.Responses.Contacts;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IContactsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Contact Get(GetRequest request);
        Task<Contact> GetAsync(GetRequest request);
        Contact Create(CreateRequest request);
        Task<Contact> CreateAsync(CreateRequest request);
        Contact Update(UpdateRequest request);
        Task<Contact> UpdateAsync(UpdateRequest request);
    }

    public class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ContactsClient(string baseUri, string bearerToken)
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

        public Contact Get(GetRequest request)
        {
            return Get<Contact>(request);
        }

        public async Task<Contact> GetAsync(GetRequest request)
        {
            return await GetAsync<Contact>(request);
        }

        public Contact Create(CreateRequest request)
        {
            return Post<Contact, CreateRequest>(request);
        }

        public async Task<Contact> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Contact, CreateRequest>(request);
        }

        public Contact Update(UpdateRequest request)
        {
            return Put<Contact, UpdateRequest>(request);
        }

        public async Task<Contact> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Contact, UpdateRequest>(request);
        }
    }
}
