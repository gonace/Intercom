namespace Intercom.Requests.Messages.Shared
{
    /// <summary>
    /// The sender of the message.
    /// If not provided, the default sender will be used.
    /// </summary>
    public class From
    {
        /// <summary>
        /// Always admin.
        /// </summary>
        public Constants.Messages.From Type = Constants.Messages.From.Admin;
        /// <summary>
        /// The identifier for the admin which is given by Intercom.
        /// </summary>
        public int Id { get; set; }

        public From(int id)
        {
            Id = id;
        }
    }
}