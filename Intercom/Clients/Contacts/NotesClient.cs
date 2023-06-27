using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Contacts.Notes;
using Intercom.Responses.Contacts.Notes;
using System.Threading.Tasks;

namespace Intercom.Clients.Contacts
{
    public interface INotesClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Note Create(CreateRequest request);
        Task<Note> CreateAsync(CreateRequest request);
    }

    internal class NotesClient : BaseClient<NotesClient>, INotesClient
    {
        public NotesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public NotesClient(Url url, string bearerToken)
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

        public Note Create(CreateRequest request)
        {
            return Post<Note, CreateRequest>(request);
        }

        public async Task<Note> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Note, CreateRequest>(request);
        }
    }
}
