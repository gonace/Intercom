using Intercom.Abstractions;
using Intercom.Models.Embedded;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// The Articles API is a central place to gather all information and take actions on your articles.
    /// Articles can live within collections and sections, or alternatively they can stand alone.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-article-model">Documentation</see>
    /// </summary>
    public class Article : Model
    {
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
        [JsonProperty("parent_type")]
        public string ParentType { get; set; }
        [JsonProperty("default_locale")]
        public string DefaultLocale { get; set; }

        [JsonProperty("translated_content")]
        public ArticleTranslatedContent TranslatedContent { get; set; }
        [JsonProperty("statistics")]
        public ArticleStatistics Statistics { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
