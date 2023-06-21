using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface INotesClient
    {
    }

    public class NotesClient : BaseClient<NotesClient>, INotesClient
    {
        public NotesClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public NotesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
