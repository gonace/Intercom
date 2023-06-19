using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface INotesClient
    {
    }

    public class NotesClient : BaseClient<NotesClient>, INotesClient
    {
        public NotesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
