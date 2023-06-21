using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface IExportsClient
    {
    }

    public class ExportsClient : BaseClient<ExportsClient>, IExportsClient
    {
        public ExportsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public ExportsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
