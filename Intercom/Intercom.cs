using Intercom.Clients;
using Intercom.Constants;
using Intercom.Exceptions;
using Intercom.Internals;

namespace Intercom
{
    public static class Intercom
    {
        private static readonly Service Service = new Service();

        /// <summary>
        /// Configures the instance.
        /// Must be called before any other methods.
        /// </summary>
        public static void Configure(Url url, string bearerToken)
        {
            Service.Configure(url, bearerToken);
        }

        public static void Configure(Url url, string bearerToken, Version version)
        {
            Service.Configure(url, bearerToken, version);
        }

        public static IAdminsClient Admins
        {
            get
            {
                if (Service.Admins == null)
                    throw new NotConfiguredException();

                return Service.Admins;
            }
        }

        public static IArticlesClient Articles
        {
            get
            {
                if (Service.Articles == null)
                    throw new NotConfiguredException();

                return Service.Articles;
            }
        }

        public static IAttributesClient Attributes
        {
            get
            {
                if (Service.Attributes == null)
                    throw new NotConfiguredException();

                return Service.Attributes;
            }
        }

        public static ICompaniesClient Companies
        {
            get
            {
                if (Service.Companies == null)
                    throw new NotConfiguredException();

                return Service.Companies;
            }
        }

        public static IContactsClient Contacts
        {
            get
            {
                if (Service.Contacts == null)
                    throw new NotConfiguredException();

                return Service.Contacts;
            }
        }

        public static IConversationsClient Conversations
        {
            get
            {
                if (Service.Conversations == null)
                    throw new NotConfiguredException();

                return Service.Conversations;
            }
        }

        public static IEventsClient Events
        {
            get
            {
                if (Service.Events == null)
                    throw new NotConfiguredException();

                return Service.Events;
            }
        }

        public static IExportsClient Exports
        {
            get
            {
                if (Service.Exports == null)
                    throw new NotConfiguredException();

                return Service.Exports;
            }
        }

        public static IMeClient Me
        {
            get
            {
                if (Service.Me == null)
                    throw new NotConfiguredException();

                return Service.Me;
            }
        }

        public static IMessagesClient Messages
        {
            get
            {
                if (Service.Messages == null)
                    throw new NotConfiguredException();

                return Service.Messages;
            }
        }

        public static INewsClient News
        {
            get
            {
                if (Service.News == null)
                    throw new NotConfiguredException();

                return Service.News;
            }
        }

        public static INotesClient Notes
        {
            get
            {
                if (Service.Notes == null)
                    throw new NotConfiguredException();

                return Service.Notes;
            }
        }

        public static ISegmentsClient Segments
        {
            get
            {
                if (Service.Segments == null)
                    throw new NotConfiguredException();

                return Service.Segments;
            }
        }

        public static ISubscriptionsClient Subscriptions
        {
            get
            {
                if (Service.Subscriptions == null)
                    throw new NotConfiguredException();

                return Service.Subscriptions;
            }
        }

        public static ISwitchClient Switch
        {
            get
            {
                if (Service.Switch == null)
                    throw new NotConfiguredException();

                return Service.Switch;
            }
        }

        public static ITagsClient Tags
        {
            get
            {
                if (Service.Tags == null)
                    throw new NotConfiguredException();

                return Service.Tags;
            }
        }

        public static ITeamsClient Teams
        {
            get
            {
                if (Service.Teams == null)
                    throw new NotConfiguredException();

                return Service.Teams;
            }
        }

        public static ITicketsClient Tickets
        {
            get
            {
                if (Service.Tickets == null)
                    throw new NotConfiguredException();

                return Service.Tickets;
            }
        }

        public static IVisitorsClient Visitors
        {
            get
            {
                if (Service.Tickets == null)
                    throw new NotConfiguredException();

                return Service.Visitors;
            }
        }

        public static bool Configured =>
            Service.Admins != null &&
            Service.Articles != null &&
            Service.Attributes != null &&
            Service.Companies != null &&
            Service.Contacts != null &&
            Service.Conversations != null &&
            Service.Events != null &&
            Service.Exports != null &&
            Service.Me != null &&
            Service.Messages != null &&
            Service.News != null &&
            Service.Notes != null &&
            Service.Segments != null &&
            Service.Subscriptions != null &&
            Service.Switch != null &&
            Service.Tags != null &&
            Service.Teams != null &&
            Service.Tickets != null &&
            Service.Visitors != null;

        public static void Dispose()
        {
            Service.Dispose();
        }
    }
}
