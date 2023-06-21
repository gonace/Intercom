using Intercom.Clients;
using System;

namespace Intercom.Internals
{
    internal class IntercomService : IDisposable
    {
        public AdminsClient Admins;
        public ArticlesClient Articles;
        public AttributesClient Attributes;
        public CompaniesClient Companies;
        public ContactsClient Contacts;
        public ConversationsClient Conversations;
        public EventsClient Events;
        public ExportsClient Exports;
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
        /// Configures the instance and must be called before any other methods.
        /// </summary>
        /// <param name="baseUri"></param>
        /// <param name="bearerToken"></param>
        /// <param name="version"></param>
        public void Configure(string baseUri, string bearerToken, Version version)
        {
            Admins = new AdminsClient(baseUri, bearerToken, version);
            Articles = new ArticlesClient(baseUri, bearerToken, version);
            Attributes = new AttributesClient(baseUri, bearerToken, version);
            Companies = new CompaniesClient(baseUri, bearerToken, version);
            Contacts = new ContactsClient(baseUri, bearerToken, version);
            Conversations = new ConversationsClient(baseUri, bearerToken, version);
            Events = new EventsClient(baseUri, bearerToken, version);
            Exports = new ExportsClient(baseUri, bearerToken, version);
            Me = new MeClient(baseUri, bearerToken, version);
            Messages = new MessagesClient(baseUri, bearerToken, version);
            News = new NewsClient(baseUri, bearerToken, version);
            Notes = new NotesClient(baseUri, bearerToken, version);
            Segments = new SegmentsClient(baseUri, bearerToken, version);
            Subscriptions = new SubscriptionsClient(baseUri, bearerToken, version);
            Switch = new SwitchClient(baseUri, bearerToken, version);
            Tags = new TagsClient(baseUri, bearerToken, version);
            Teams = new TeamsClient(baseUri, bearerToken, version);
            Tickets = new TicketsClient(baseUri, bearerToken, version);
            Visitors = new VisitorsClient(baseUri, bearerToken, version);
        }

        /// <summary>
        /// Configures the instance and must be called before any other methods.
        /// </summary>
        /// <param name="baseUri"></param>
        /// <param name="bearerToken"></param>
        public void Configure(string baseUri, string bearerToken)
        {
            Admins = new AdminsClient(baseUri, bearerToken);
            Articles = new ArticlesClient(baseUri, bearerToken);
            Attributes = new AttributesClient(baseUri, bearerToken);
            Companies = new CompaniesClient(baseUri, bearerToken);
            Contacts = new ContactsClient(baseUri, bearerToken);
            Conversations = new ConversationsClient(baseUri, bearerToken);
            Events = new EventsClient(baseUri, bearerToken);
            Exports = new ExportsClient(baseUri, bearerToken);
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
