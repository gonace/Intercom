using Intercom.Abstractions;

namespace Intercom.Requests.Teams
{
    /// <summary>
    /// This will return a list of team objects for the App.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listteams">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "teams";
    }
}
