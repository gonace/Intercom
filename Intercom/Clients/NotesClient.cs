using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface INotesClient
    {
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
    }
}
