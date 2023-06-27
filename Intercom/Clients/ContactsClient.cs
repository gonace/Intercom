using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Contacts;
using Intercom.Responses.Contacts;
using Intercom.Responses.Generic;
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
        DeleteResponse Delete(DeleteRequest request);
        Task<DeleteResponse> DeleteAsync(DeleteRequest request);

        ArchiveResponse Archive(ArchiveRequest request);
        Task<ArchiveResponse> ArchiveAsync(ArchiveRequest request);
        Contact Merge(MergeRequest request);
        Task<Contact> MergeAsync(MergeRequest request);

        Contacts.ICompaniesClient Companies { get; }
        Contacts.INotesClient Notes { get; }
        Contacts.ISegmentsClient Segments { get; }
        Contacts.ISubscriptionClient Subscriptions { get; }
        Contacts.ITagsClient Tags { get; }
    }

    public class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
            Companies = new Contacts.CompaniesClient(url, bearerToken, version);
            Notes = new Contacts.NotesClient(url, bearerToken, version);
            Segments = new Contacts.SegmentsClient(url, bearerToken, version);
            Subscriptions = new Contacts.SubscriptionsClient(url, bearerToken, version);
            Tags = new Contacts.TagsClient(url, bearerToken, version);
        }

        public ContactsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
            Companies = new Contacts.CompaniesClient(url, bearerToken);
            Notes = new Contacts.NotesClient(url, bearerToken);
            Segments = new Contacts.SegmentsClient(url, bearerToken);
            Subscriptions = new Contacts.SubscriptionsClient(url, bearerToken);
            Tags = new Contacts.TagsClient(url, bearerToken);
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

        public DeleteResponse Delete(DeleteRequest request)
        {
            return Delete<DeleteResponse>(request);
        }

        public async Task<DeleteResponse> DeleteAsync(DeleteRequest request)
        {
            return await DeleteAsync<DeleteResponse>(request);
        }

        public ArchiveResponse Archive(ArchiveRequest request)
        {
            return Post<ArchiveResponse>(request);
        }

        public async Task<ArchiveResponse> ArchiveAsync(ArchiveRequest request)
        {
            return await PostAsync<ArchiveResponse>(request);
        }

        public Contact Merge(MergeRequest request)
        {
            return Post<Contact, MergeRequest>(request);
        }

        public async Task<Contact> MergeAsync(MergeRequest request)
        {
            return await PostAsync<Contact, MergeRequest>(request);
        }

        public Contacts.ICompaniesClient Companies { get; }
        public Contacts.INotesClient Notes { get; }
        public Contacts.ISegmentsClient Segments { get; }
        public Contacts.ISubscriptionClient Subscriptions { get; }
        public Contacts.ITagsClient Tags { get; }
    }
}
