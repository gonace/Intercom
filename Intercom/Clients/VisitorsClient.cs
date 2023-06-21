using Intercom.Abstractions;
using Intercom.Constants;

namespace Intercom.Clients
{
    public interface IVisitorsClient
    {
    }

    public class VisitorsClient : BaseClient<VisitorsClient>, IVisitorsClient
    {
        public VisitorsClient(string baseUri, string bearerToken, string apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public VisitorsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Version.Latest)
        {
        }
    }
}
