using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// Visitors are useful for representing anonymous people that have not yet been identified.
    /// They usually represent website visitors.
    /// Visitors are not visible in Intercom platform.
    /// The Visitors resource provides methods to fetch, update, convert, and delete.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-visitor-model">Documentation</see>
    /// </summary>
    public class Visitor : Model
    {
        /// <summary>
        /// The id of the app the visitor is associated with.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        /// <summary>
        /// Automatically generated identifier for the Visitor.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Identifies if this visitor is anonymous.
        /// </summary>
        [JsonProperty("anonymous")]
        public bool Anonymous { get; set; }
        /// <summary>
        /// The email of the visitor.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// The phone number of the visitor.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        /// The name of the visitor.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The pseudonym of the visitor.
        /// </summary>
        [JsonProperty("pseudonym")]
        public string Pseudonym { get; set; }


        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }
    }
}
