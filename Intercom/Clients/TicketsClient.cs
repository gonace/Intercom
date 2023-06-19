using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ITicketsClient
    {
    }

    public class TicketsClient : BaseClient<TicketsClient>, ITicketsClient
    {
        public TicketsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
