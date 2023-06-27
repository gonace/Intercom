using Intercom.Abstractions;
using Intercom.Constants;
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
        public NotesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public NotesClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
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
