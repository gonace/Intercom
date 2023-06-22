using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can merge a contact with a role of lead into a contact with a role of user.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/mergecontact">Documentation</see>
    /// </summary>
    public class MergeRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the contact to merge away from. Must be a lead.
        /// </summary>
        public string FromId { get; }
        /// <summary>
        /// The unique identifier for the contact to merge into. Must be a user.
        /// </summary>
        public string ToId { get; }

        public MergeRequest(string fromId, string toId)
        {
            FromId = fromId;
            ToId = toId;
        }

        public override object Payload => new
        {
            from = FromId,
            into = ToId
        };

        public override string Uri => "contacts/merge";
    }
}
