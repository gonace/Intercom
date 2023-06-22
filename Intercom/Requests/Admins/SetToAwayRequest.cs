using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Admins
{
    /// <summary>
    /// You can set an Admin as away for the Inbox.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/setawayadmin">Documentation</see>
    /// </summary>
    public class SetToAwayRequest : PayloadRequest
    {
        public string Id { get; }
        /// <summary>
        /// Set to "true" to change the status of the admin to away.
        /// </summary>
        public bool AwayModeEnabled { get; }
        /// <summary>
        /// Set to "true" to assign any new conversation replies to your default inbox.
        /// </summary>
        public bool AwayModeReassign { get; }

        public SetToAwayRequest(Admin admin)
        {
            Id = admin.Id;
            AwayModeEnabled = admin.AwayModeEnabled ?? false;
            AwayModeReassign = admin.AwayModeReassign ?? false;
        }

        public SetToAwayRequest(string id, bool awayModeEnabled, bool awayModeReassign)
        {
            Id = id;
            AwayModeEnabled = awayModeEnabled;
            AwayModeReassign = awayModeReassign;
        }

        public override object Payload => new
        {
            away_mode_enabled = AwayModeEnabled,
            away_mode_reassign = AwayModeReassign
        };

        public override string Uri => $"admins/{Id}/away";
    }
}
