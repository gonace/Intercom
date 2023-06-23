using Intercom.Abstractions;

namespace Intercom.Requests.Exports
{
    /// <summary>
    /// To create your export job, you need to send a POST request to the export
    /// endpoint https://api.intercom.io/export/content/data.
    /// <br/><br/>
    /// The only parameters you need to provide are the range of dates that you
    /// want exported.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/create-data-export">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The start date that you request data for. It must be formatted as a unix timestamp.
        /// </summary>
        public long CreatedAtAfter { get; }
        /// <summary>
        /// The end date that you request data for. It must be formatted as a unix timestamp.
        /// </summary>
        public long CreatedAtBefore { get; }

        public CreateRequest(long createdAtAfter, long createdAtBefore)
        {
            CreatedAtAfter = createdAtAfter;
            CreatedAtBefore = createdAtBefore;
        }

        public override object Payload => new
        {
            created_at_after = CreatedAtAfter,
            created_at_before = CreatedAtBefore,
        };

        public override string Uri => "export/content/data";
    }
}
