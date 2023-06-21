using Intercom.Abstractions;
using Intercom.Models.Shared;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// The Help Center API is a central place to gather all information and take actions on those elements
    /// within a Help Center - namely the collections and sections. Collections are top level containers
    /// for Articles within the Help Center. Sections are subdivisions of a collection, with a collection
    /// potentially having multiple sections.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-collection-model">Documentation</see>
    /// </summary>
    public class Collection : Model
    {
        /// <summary>
        /// The id of the workspace which the collection belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The name of the collection. For multilingual collections, this will be the name of the default language's
        /// content.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The description of the collection. For multilingual help centers, this will be the description of the collection
        /// for the default language.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The URL of the collection. For multilingual help centers, this will be the URL of the collection for the default
        /// language.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// The icon of the collection.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }
        /// <summary>
        /// The order of the section in relation to others sections within a collection. Values go from 0`` upwards. 0`` is the
        /// default if there's no order.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }
        /// <summary>
        /// The default locale of the help center. This field is only returned for multilingual help centers.
        /// </summary>
        [JsonProperty("default_locale")]
        public string DefaultLocale { get; set; }
        /// <summary>
        /// The Translated Content of an Group. The keys are the locale codes and the values are the translated content of the Group.
        /// </summary>
        [JsonProperty("translated_content")]
        public TranslatedContent TranslatedContent { get; set; }

        /// <summary>
        /// The time when the article was created. For multilingual articles, this will be the timestamp of creation of the default
        /// language's content.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        ///  The time when the article was last updated. For multilingual articles, this will be the timestamp of last update of the default
        /// language's content.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
