using Intercom.Abstractions;

namespace Intercom.Requests.Exports
{
    /// <summary>
    /// You can cancel your job.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/cancel-data-export">Documentation</see>
    /// </summary>
    public class CancelRequest : PlainRequest
    {
        /// <summary>
        /// Job identifier.
        /// </summary>
        public string JobIdentifier { get; set; }

        public CancelRequest(string jobIdentifier)
        {
            JobIdentifier = jobIdentifier;
        }

        public override string Uri => $"export/cancel/{JobIdentifier}";
    }
}
