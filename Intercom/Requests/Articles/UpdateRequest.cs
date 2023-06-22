﻿using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Models.Shared;

namespace Intercom.Requests.Articles
{
    /// <summary>
    /// You can update the details of a single article by making a PUT
    /// request to https://api.intercom.io/articles/<id>.
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the article which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The title of the article.For multilingual articles, this will be
        /// the title of the default language's content.
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// The description of the article. For multilingual articles,
        /// this will be the description of the default language's content.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// The content of the article. For multilingual articles,
        /// this will be the body of the default language's content.
        /// </summary>
        public string Body { get; }
        /// <summary>
        /// The id of the author of the article. For multilingual articles,
        /// this will be the id of the author of the default language's content.
        ///
        /// Must be a teammate on the help center's workspace.
        /// </summary>
        public int AuthorId { get; }
        /// <summary>
        /// Whether the article will be published or will be a draft.
        /// Defaults to draft. For multilingual articles, this will be the
        /// state of the default language's content.
        /// </summary>
        public string State { get; }
        /// <summary>
        /// The id of the article's parent collection or section.
        /// An article without this field stands alone.
        /// </summary>
        public int ParentId { get; }
        /// <summary>
        /// The type of parent, which can either be a collection or section.
        /// </summary>
        public string ParentType { get; }
        /// <summary>
        /// The Translated Content of an Article. The keys are the locale codes
        /// and the values are the translated content of the article.
        /// </summary>
        public TranslatedContent TranslatedContent { get; }

        public UpdateRequest(Article article)
        {
            Id = article.Id;
            Title = article.Title;
            Description = article.Description;
            Body = article.Body;
            AuthorId = article.AuthorId;
            State = article.State;
            ParentId = article.ParentId;
            ParentType = article.ParentType;
            TranslatedContent = article.TranslatedContent;
        }

        public UpdateRequest(string id, string title, string description, string body, int authorId, string state, int parentId, string parentType, TranslatedContent translatedContent)
        {
            Id = id;
            Title = title;
            Description = description;
            Body = body;
            AuthorId = authorId;
            State = state;
            ParentId = parentId;
            ParentType = parentType;
            TranslatedContent = translatedContent;
        }

        public override object Payload => new
        {
            title = Title,
            description = Description,
            body = Body,
            author_id = AuthorId,
            state = State,
            parent_id = ParentId,
            parent_type = ParentType,
            translated_content = TranslatedContent
        };

        public override string Uri => $"articles/{Id}";
    }
}
