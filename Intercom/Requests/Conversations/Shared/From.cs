using Intercom.Constants.Conversations;

namespace Intercom.Requests.Conversations.Shared
{
    public class From
    {
        /// <summary>
        /// The role associated to the contact, user, or lead.
        /// </summary>
        public Type Type { get; set; }
        /// <summary>
        /// The identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; set; }

        public From(Type type, string id)
        {
            Type = type;
            Id = id;
        }
    }
}
