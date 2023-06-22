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

        public static IAdminsClient Admins = Service.Admins;
        public static IArticlesClient Articles = Service.Articles;
        public static IAttributesClient Attributes = Service.Attributes;
        public static ICompaniesClient Companies = Service.Companies;
        public static IContactsClient Contacts = Service.Contacts;
        public static IConversationsClient Conversations = Service.Conversations;
        public static IEventsClient Events = Service.Events;
        public static IExportsClient Exports = Service.Exports;
        public static IMeClient Me = Service.Me;
        public static IMessagesClient Messages = Service.Messages;
        public static INewsClient News = Service.News;
        public static INotesClient Notes = Service.Notes;
        public static ISegmentsClient Segments = Service.Segments;
        public static ISubscriptionsClient Subscriptions = Service.Subscriptions;
        public static ISwitchClient Switch = Service.Switch;
        public static ITagsClient Tags = Service.Tags;
        public static ITeamsClient Teams = Service.Teams;
        public static ITicketsClient Tickets = Service.Tickets;
        public static IVisitorsClient Visitors = Service.Visitors;
    }
}
