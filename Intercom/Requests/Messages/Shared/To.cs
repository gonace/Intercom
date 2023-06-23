namespace Intercom.Requests.Messages.Shared
{
    /// <summary>
    /// The receiver of the message.
    /// </summary>
    public class To
    {
        /// <summary>
        /// The role associated to the contact - user or lead.
        /// </summary>
        public Constants.Messages.To Type { get; set; }
        /// <summary>
        /// The identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; set; }

        public To(Constants.Messages.To to, string id)
        {
            Type = to;
            Id = id;
        }
    }
}