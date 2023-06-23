using Intercom.Abstractions;
using Intercom.Constants.Articles;
using Intercom.Models;
using Intercom.Models.Shared;

namespace Intercom.Requests.Articles
{
    /// <summary>
    /// You can create a new article by making a POST
    /// request to https://api.intercom.io/articles.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createarticle">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The title of the article.For multilingual articles,
        /// this will be the title of the default language's content.
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// The description of the article. For multilingual articles,
        /// this will be the description of the default language's content.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The content of the article. For multilingual articles,
        /// this will be the body of the default language's content.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The id of the author of the article. For multilingual articles,
        /// this will be the id of the author of the default language's content.
        ///
        /// Must be a teammate on the help center's workspace.
        /// </summary>
        public int AuthorId { get; }
        /// <summary>
        /// Whether the article will be published or will be a draft.
        /// Defaults to draft. For multilingual articles,
        /// this will be the state of the default language's content.
        /// </summary>
        public State State { get; set; }
        /// <summary>
        /// The id of the article's parent collection or section.
        /// An article without this field stands alone.
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// The type of parent, which can either be a collection or section.
        /// </summary>
        public string ParentType { get; set; }
        /// <summary>
        /// The Translated Content of an Article. The keys are the locale codes
        /// and the values are the translated content of the article.
        /// </summary>
        public TranslatedContent TranslatedContent { get; set; }

        public CreateRequest(Article article, State state)
        {
            Title = article.Title;
            Description = article.Description;
            Body = article.Body;
            AuthorId = article.AuthorId;
            State = state;
            ParentId = article.ParentId;
            ParentType = article.ParentType;
            TranslatedContent = article.TranslatedContent;
        }

        public CreateRequest(string title, int authorId)
        {
            Title = title;
            AuthorId = authorId;
        }

        public override object Payload => new
        {
            title = Title,
            description = Description,
            body = Body,
            author_id = AuthorId,
            state = State.ToString(),
            parent_id = ParentId,
            parent_type = ParentType,
            translated_content = TranslatedContent
        };

        public override string Uri => "articles";
    }
}
