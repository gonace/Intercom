using Intercom.Abstractions;

namespace Intercom.Requests.Exports
{
    /// <summary>
    /// You can view the status of your job by sending a GET
    /// request to the URL https://api.intercom.io/export/content/data/{job_identifier}
    /// - the {job_identifier} is the value returned in the response when you first created the export job.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/get-data-export">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// Job identifier.
        /// </summary>
        public string JobIdentifier { get; set; }

        public GetRequest(string jobIdentifier)
        {
            JobIdentifier = jobIdentifier;
        }

        public override string Uri => $"export/content/data/{JobIdentifier}";
    }
}
