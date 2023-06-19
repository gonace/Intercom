using Intercom.Clients;
using System;

namespace Intercom.Internals
{
    internal class IntercomService : IDisposable
    {
        public AdminsClient Admins;
        public ArticlesClient Articles;
        public CompaniesClient Companies;
        public ContactsClient Contacts;
        public ConversationsClient Conversations;
        public MeClient Me;
        public MessagesClient Messages;
        public NewsClient News;
        public NotesClient Notes;
        public SegmentsClient Segments;
        public SubscriptionsClient Subscriptions;
        public SwitchClient Switch;
        public TagsClient Tags;
        public TeamsClient Teams;
        public TicketsClient Tickets;
        public VisitorsClient Visitors;

        /// <summary>
        /// Configures the instance.
        /// Must be called before any other methods.
        /// </summary>
        public void Configure(string baseUri, string bearerToken)
        {
            Admins = new AdminsClient(baseUri, bearerToken);
            Articles = new ArticlesClient(baseUri, bearerToken);
            Companies = new CompaniesClient(baseUri, bearerToken);
            Contacts = new ContactsClient(baseUri, bearerToken);
            Conversations = new ConversationsClient(baseUri, bearerToken);
            Me = new MeClient(baseUri, bearerToken);
            Messages = new MessagesClient(baseUri, bearerToken);
            News = new NewsClient(baseUri, bearerToken);
            Notes = new NotesClient(baseUri, bearerToken);
            Segments = new SegmentsClient(baseUri, bearerToken);
            Subscriptions = new SubscriptionsClient(baseUri, bearerToken);
            Switch = new SwitchClient(baseUri, bearerToken);
            Tags = new TagsClient(baseUri, bearerToken);
            Teams = new TeamsClient(baseUri, bearerToken);
            Tickets = new TicketsClient(baseUri, bearerToken);
            Visitors = new VisitorsClient(baseUri, bearerToken);
        }

        public void Dispose()
        {
            //Admins?.Dispose();
        }
    }
}
