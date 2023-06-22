using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Conversations;
using Intercom.Responses.Conversations;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IConversationsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Conversation Get(GetRequest request);
        Task<Conversation> GetAsync(GetRequest request);
        Conversation Create(CreateRequest request);
        Task<Conversation> CreateAsync(CreateRequest request);

        Conversations.IContactsClient Contacts { get; }
        Conversations.ITagsClient Tags { get; }
    }

    public class ConversationsClient : BaseClient<ConversationsClient>, IConversationsClient
    {
        public ConversationsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
            Contacts = new Conversations.ContactsClient(baseUri, bearerToken, apiVersion);
            Tags = new Conversations.TagsClient(baseUri, bearerToken, apiVersion);
        }

        public ConversationsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
            Contacts = new Conversations.ContactsClient(baseUri, bearerToken);
            Tags = new Conversations.TagsClient(baseUri, bearerToken);
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Conversation Get(GetRequest request)
        {
            return Get<Conversation>(request);
        }

        public async Task<Conversation> GetAsync(GetRequest request)
        {
            return await GetAsync<Conversation>(request);
        }

        public Conversation Create(CreateRequest request)
        {
            return Post<Conversation, CreateRequest>(request);
        }

        public async Task<Conversation> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Conversation, CreateRequest>(request);
        }

        public Conversations.IContactsClient Contacts { get; }
        public Conversations.ITagsClient Tags { get; }
    }
}
