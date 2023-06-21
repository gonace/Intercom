using Intercom.Abstractions;
using Intercom.Converters;
using Intercom.Models.Companies;
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
        /// <summary>
        /// The Intercom defined code of the workspace the company is associated to.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// The company id you have defined for the company.
        /// </summary>
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The number of employees in the company.
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }
        /// <summary>
        /// The URL for the company website.
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }
        /// <summary>
        /// The industry that the company operates in.
        /// </summary>
        [JsonProperty("industry")]
        public string Industry { get; set; }
        /// <summary>
        /// How much revenue the company generates for your business.
        /// </summary>
        [JsonProperty("monthly_spend")]
        public decimal? MonthlySpend { get; set; }
        /// <summary>
        /// How many sessions the company has recorded.
        /// </summary>
        [JsonProperty("session_count")]
        public int? SessionCount { get; set; }
        /// <summary>
        /// The number of users in the company.
        /// </summary>
        [JsonProperty("user_count")]
        public int? UserCount { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }
        /// <summary>
        /// The custom attributes you have set on the company.
        /// </summary>
        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        /// <summary>
        /// The list of tags associated with the company.
        /// </summary>
        [JsonConverter(typeof(TagsConverter))]
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// The list of segments associated with the company
        /// </summary>
        [JsonConverter(typeof(SegmentsConverter))]
        [JsonProperty("segments")]
        public List<Segment> Segments { get; set; }

        /// <summary>
        /// The time the company last recorded making a request.
        /// </summary>
        [JsonProperty("last_request_at")]
        public long? LastRequestAt { get; set; }
        /// <summary>
        /// The time the company was created by you.
        /// </summary>
        [JsonProperty("remote_created_at")]
        public long? RemoteCreatedAt { get; set; }
        /// <summary>
        /// The time the company was added in Intercom.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The last time the company was updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
