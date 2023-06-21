using Intercom.Abstractions;
using Intercom.Constants;
using System;

namespace Intercom.Clients
{
    public interface ISegmentsClient
    {
    }

    public class SegmentsClient : BaseClient<SegmentsClient>, ISegmentsClient
    {
        public SegmentsClient(string baseUri, string bearerToken, Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SegmentsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, ApiVersion.Latest)
        {
        }
    }
}
