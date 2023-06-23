using Intercom.Abstractions;

namespace Intercom.Requests.Exports
{
    /// <summary>
    /// When a job has a status of complete, and thus a filled download_url,
    /// you can download your data by hitting that provided URL,
    /// formatted like so: https://api.intercom.io/download/content/data/xyz1234.
    /// <br/><br/>
    /// Your exported message data will be streamed continuously back down to you
    /// in a gzipped CSV format.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/download-data-export">Documentation</see>
    /// </summary>
    public class DownloadRequest : StreamRequest
    {
        /// <summary>
        /// Job identifier.
        /// </summary>
        public string JobIdentifier { get; set; }

        public DownloadRequest(string jobIdentifier)
        {
            JobIdentifier = jobIdentifier;
        }

        public override string Uri => $"download/content/data/{JobIdentifier}";
    }
}
