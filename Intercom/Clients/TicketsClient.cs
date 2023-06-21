using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ITicketsClient
    {
    }

    public class TicketsClient : BaseClient<TicketsClient>, ITicketsClient
    {
        public TicketsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TicketsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
