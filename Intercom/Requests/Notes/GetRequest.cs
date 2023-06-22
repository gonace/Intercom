using Intercom.Abstractions;

namespace Intercom.Requests.Notes
{
    /// <summary>
    /// You can fetch the details of a single note.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievenote">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier of a given note.
        /// </summary>
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"notes/{Id}";
    }
}
