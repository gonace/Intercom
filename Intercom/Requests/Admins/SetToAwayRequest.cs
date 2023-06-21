using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Admins
{
    public class SetToAwayRequest : PayloadRequest
    {
        public Admin Admin { get; }

        public SetToAwayRequest(Admin admin)
        {
            Admin = admin;
        }

        public override object Payload => new
        {
            away_mode_enabled = Admin.AwayModeEnabled,
            away_mode_reassign = Admin.AwayModeReassign
        };

        public override string Uri => $"admins/{Admin.Id}/away";
    }
}
