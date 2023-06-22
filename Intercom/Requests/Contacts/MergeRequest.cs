using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can merge a contact with a role of lead into a contact with a role of user.
    /// </summary>
    public class MergeRequest : PayloadRequest
    {
        public string FromId { get; }
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
