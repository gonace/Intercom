using Intercom.Abstractions;
using Intercom.Models.News;

namespace Intercom.Requests.News.Items
{
    /// <summary>
    /// You can create a news item.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievenewsitem">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The title of the news item.
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// The news item body, which may contain HTML.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The id of the sender of the news item. Must be a teammate on the workspace.
        /// </summary>
        public int SenderId { get; }
        /// <summary>
        /// News items will not be visible to your users in the assigned news feeds
        /// until they are set live.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// When set to true, the news item will appear in the messenger news feed
        /// without showing a notification badge.
        /// </summary>
        public bool DeliverSilently { get; set; }
        /// <summary>
        /// Label names displayed to users to categorize the news item.
        /// </summary>
        public string[] Labels { get; set; }
        /// <summary>
        /// Ordered list of emoji reactions to the news item. When empty,
        /// reactions are disabled.
        /// </summary>
        public string[] Reactions { get; set; }

        public CreateRequest(Item news)
        {
            Title = news.Title;
            Body = news.Body;
            SenderId = news.SenderId;
            State = news.State;
            DeliverSilently = news.DeliverSilently;
            Labels = news.Labels;
            Reactions = news.Reactions;
        }

        public CreateRequest(string title, int senderId)
        {
            Title = title;
            SenderId = senderId;
        }

        public override object Payload => new
        {
            title = Title,
            body = Body,
            sender_id = SenderId,
            state = State,
            deliver_silently = DeliverSilently,
            lables = Labels,
            reactions = Reactions
        };

        public override string Uri => "news/news_items";
    }
}
