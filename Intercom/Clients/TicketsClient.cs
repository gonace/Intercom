using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface ITicketsClient
    {
    }

    public class TicketsClient : BaseClient<TicketsClient>, ITicketsClient
    {
        public TicketsClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TicketsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
