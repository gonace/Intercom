using Intercom.Abstractions;

namespace Intercom.Requests.Segments
{
    /// <summary>
    /// You can fetch a list of all segments.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievesegment">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "segments";
    }
}
