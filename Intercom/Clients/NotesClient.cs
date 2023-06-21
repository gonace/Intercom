using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Notes;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface INotesClient
    {
        Note Get(GetRequest request);
        Task<Note> GetAsync(GetRequest request);
    }

    public class NotesClient : BaseClient<NotesClient>, INotesClient
    {
        public NotesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public NotesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public Note Get(GetRequest request)
        {
            return Get<Note>(request);
        }

        public async Task<Note> GetAsync(GetRequest request)
        {
            return await GetAsync<Note>(request);
        }
    }
}
