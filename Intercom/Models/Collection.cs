using Intercom.Abstractions;
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
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
        [JsonProperty("default_locale")]
        public string DefaultLocale { get; set; }
        //TODO: Implement this
        //[JsonProperty("translated_content")]
        //public TranslatedContent TranslatedContent { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
