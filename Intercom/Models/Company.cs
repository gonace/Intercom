using Intercom.Abstractions;
using Intercom.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// Companies allow you to represent organizations using your product.
    /// Each company will have its own description and be associated with contacts.
    /// You can fetch, create, update and list companies.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-company-model">Documentation</see>
    /// </summary>
    public class Company : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("plan")]
        public Plan Plan { get; set; }
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }
        [JsonProperty("monthly_spend")]
        public decimal? MonthlySpend { get; set; }
        [JsonProperty("session_count")]
        public int? SessionCount { get; set; }
        [JsonProperty("user_count")]
        public int? UserCount { get; set; }
        [JsonProperty("size")]
        public int? Size { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("industry")]
        public string Industry { get; set; }
        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        [JsonConverter(typeof(TagsConverter))]
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("last_request_at")]
        public long? LastRequestAt { get; set; }
        [JsonProperty("remote_created_at")]
        public long? RemoteCreatedAt { get; set; }
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
