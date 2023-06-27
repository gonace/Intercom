using Intercom.Clients;
using Intercom.Constants;
using System;

namespace Intercom.Internals
{
    internal class IntercomService : IDisposable
    {
        public IAdminsClient Admins;
        public IArticlesClient Articles;
        public IAttributesClient Attributes;
        public ICompaniesClient Companies;
        public IContactsClient Contacts;
        public IConversationsClient Conversations;
        public IEventsClient Events;
        public IExportsClient Exports;
        public IMeClient Me;
        public IMessagesClient Messages;
        public INewsClient News;
        public INotesClient Notes;
        public ISegmentsClient Segments;
        public ISubscriptionsClient Subscriptions;
        public ISwitchClient Switch;
        public ITagsClient Tags;
        public ITeamsClient Teams;
        public ITicketsClient Tickets;
        public IVisitorsClient Visitors;

        /// <summary>
        /// Configures the instance and must be called before any other methods.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bearerToken"></param>
        /// <param name="version"></param>
        public void Configure(Url url, string bearerToken, Constants.Version version)
        {
            Admins = new AdminsClient(url, bearerToken, version);
            Articles = new ArticlesClient(url, bearerToken, version);
            Attributes = new AttributesClient(url, bearerToken, version);
            Companies = new CompaniesClient(url, bearerToken, version);
            Contacts = new ContactsClient(url, bearerToken, version);
            Conversations = new ConversationsClient(url, bearerToken, version);
            Events = new EventsClient(url, bearerToken, version);
            Exports = new ExportsClient(url, bearerToken, version);
            Me = new MeClient(url, bearerToken, version);
            Messages = new MessagesClient(url, bearerToken, version);
            News = new NewsClient(url, bearerToken, version);
            Notes = new NotesClient(url, bearerToken, version);
            Segments = new SegmentsClient(url, bearerToken, version);
            Subscriptions = new SubscriptionsClient(url, bearerToken, version);
            Switch = new SwitchClient(url, bearerToken, version);
            Tags = new TagsClient(url, bearerToken, version);
            Teams = new TeamsClient(url, bearerToken, version);
            Tickets = new TicketsClient(url, bearerToken, version);
            Visitors = new VisitorsClient(url, bearerToken, version);
        }

        /// <summary>
        /// Configures the instance and must be called before any other methods.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bearerToken"></param>
        public void Configure(Url url, string bearerToken)
        {
            Admins = new AdminsClient(url, bearerToken);
            Articles = new ArticlesClient(url, bearerToken);
            Attributes = new AttributesClient(url, bearerToken);
            Companies = new CompaniesClient(url, bearerToken);
            Contacts = new ContactsClient(url, bearerToken);
            Conversations = new ConversationsClient(url, bearerToken);
            Events = new EventsClient(url, bearerToken);
            Exports = new ExportsClient(url, bearerToken);
            Me = new MeClient(url, bearerToken);
            Messages = new MessagesClient(url, bearerToken);
            News = new NewsClient(url, bearerToken);
            Notes = new NotesClient(url, bearerToken);
            Segments = new SegmentsClient(url, bearerToken);
            Subscriptions = new SubscriptionsClient(url, bearerToken);
            Switch = new SwitchClient(url, bearerToken);
            Tags = new TagsClient(url, bearerToken);
            Teams = new TeamsClient(url, bearerToken);
            Tickets = new TicketsClient(url, bearerToken);
            Visitors = new VisitorsClient(url, bearerToken);
        }

        public void Dispose()
        {
            //Admins?.Dispose();
        }
    }
}
