using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IVisitorsClient
    {
    }

    public class VisitorsClient : BaseClient<VisitorsClient>, IVisitorsClient
    {
        public VisitorsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public VisitorsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
