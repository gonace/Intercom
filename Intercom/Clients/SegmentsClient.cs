﻿using Intercom.Abstractions;

namespace Intercom.Clients
{
    public interface ISegmentsClient
    {
    }

    public class SegmentsClient : BaseClient<SegmentsClient>, ISegmentsClient
    {
        public SegmentsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken)
        {
        }
    }
}
