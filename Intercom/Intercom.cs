using Intercom.Clients;
using Intercom.Internals;
using System;

namespace Intercom
{
    public static class Intercom
    {
        private static readonly IntercomService Service = new IntercomService();

        /// <summary>
        /// Configures the instance.
        /// Must be called before any other methods.
        /// </summary>
        public static void Configure(string baseUri, string bearerToken)
        {
            Service.Configure(baseUri, bearerToken);
        }

        public static void Configure(string baseUri, string bearerToken, Version apiVersion)
        {
            Service.Configure(baseUri, bearerToken, apiVersion);
        }

        public static AdminsClient Admins = Service.Admins;
        public static ArticlesClient Articles = Service.Articles;
        public static AttributesClient Attributes = Service.Attributes;
        public static CompaniesClient Companies = Service.Companies;
        public static ContactsClient Contacts = Service.Contacts;
        public static ConversationsClient Conversations = Service.Conversations;
        public static EventsClient Events = Service.Events;
        public static ExportsClient Exports = Service.Exports;
        public static MeClient Me = Service.Me;
        public static MessagesClient Messages = Service.Messages;
        public static NewsClient News = Service.News;
        public static NotesClient Notes = Service.Notes;
        public static SegmentsClient Segments = Service.Segments;
        public static SubscriptionsClient Subscriptions = Service.Subscriptions;
        public static SwitchClient Switch = Service.Switch;
        public static TagsClient Tags = Service.Tags;
        public static TeamsClient Teams = Service.Teams;
        public static TicketsClient Tickets = Service.Tickets;
        public static VisitorsClient Visitors = Service.Visitors;
    }
}
