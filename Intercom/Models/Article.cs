using Intercom.Abstractions;
using Intercom.Models.Articles;
using Intercom.Models.Shared;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// The Articles API is a central place to gather all information and take actions on your articles.
    /// Articles can live within collections and sections, or alternatively they can stand alone.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-article-model">Documentation</see>
    /// </summary>
    public class Article : Model
    {
        /// <summary>
        /// The id of the author of the article. For multilingual articles, this will be the id
        /// of the author of the default language's content. Must be a teammate on the help center's workspace.
        /// </summary>
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }
        /// <summary>
        /// The id of the workspace which the article belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The title of the article. For multilingual articles, this will be the title of the default language's content.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// The description of the article. For multilingual articles, this will be the description of the default language's
        /// content.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The body of the article in HTML. For multilingual articles, this will be the body of the default language's
        /// content.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }
        /// <summary>
        /// Whether the article is published or is a draft. For multilingual articles, this will be the state of the
        /// default language's content.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// The URL of the article. For multilingual articles, this will be the URL of the default language's content.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// The id of the article's parent collection or section. An article without this field stands alone.
        /// </summary>
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
        /// <summary>
        /// The type of parent, which can either be a collection or section.
        /// </summary>
        [JsonProperty("parent_type")]
        public string ParentType { get; set; }
        /// <summary>
        /// The default locale of the help center. This field is only returned for multilingual help centers.
        /// </summary>
        [JsonProperty("default_locale")]
        public string DefaultLocale { get; set; }

        /// <summary>
        /// The Translated Content of an Article. The keys are the locale codes and the values are the translated content of the
        /// article.
        /// </summary>
        [JsonProperty("translated_content")]
        public TranslatedContent TranslatedContent { get; set; }
        /// <summary>
        ///  The statistics of an article.
        /// </summary>
        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }

        /// <summary>
        /// The time when the article was created. For multilingual articles, this will be the timestamp of creation of the default
        /// language's content.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The time when the article was last updated. For multilingual articles, this will be the timestamp of last update of the
        /// default language's content.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
