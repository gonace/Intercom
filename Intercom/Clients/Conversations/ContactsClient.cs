using Intercom.Abstractions;
using Intercom.Requests.Conversations.Contacts;
using Intercom.Responses.Conversations.Contacts;
using System.Threading.Tasks;

namespace Intercom.Clients.Conversations
{
    public interface IContactsClient
    {
        AttachResponse Attach(AttachRequest request);
        Task<AttachResponse> AttachAsync(AttachRequest request);
        DetachResponse Detach(DetachRequest request);
        Task<DetachResponse> DetachAsync(DetachRequest request);
    }

    internal class ContactsClient : BaseClient<ContactsClient>, IContactsClient
    {
        public ContactsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ContactsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public AttachResponse Attach(AttachRequest request)
        {
            return Post<AttachResponse, AttachRequest>(request);
        }

        public async Task<AttachResponse> AttachAsync(AttachRequest request)
        {
            return await PostAsync<AttachResponse, AttachRequest>(request);
        }

        public DetachResponse Detach(DetachRequest request)
        {
            return Delete<DetachResponse, DetachRequest>(request);
        }

        public async Task<DetachResponse> DetachAsync(DetachRequest request)
        {
            return await DeleteAsync<DetachResponse, DetachRequest>(request);
        }
    }
}
