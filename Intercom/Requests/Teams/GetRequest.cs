using Intercom.Abstractions;

namespace Intercom.Requests.Teams
{
    /// <summary>
    /// You can fetch the details of a single team, containing an array of admins that belong to this team.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrieveteam">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier of a given team.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"teams/{Id}";
    }
}
