using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// Data Attributes are metadata used to describe your contact, company and conversation models.
    /// These include standard and custom attributes.
    /// By using the data attributes endpoint, you can get the global list of attributes for your workspace, as well as create and archive custom attributes.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-data-attribute-model">Documentation</see>
    /// </summary>
    public class Attribute : Model
    {
        /// <summary>
        /// Teammate who created the attribute. Only applicable to CDAs.
        /// </summary>
        [JsonProperty("admin_id")]
        public int AdminId { get; set; }

        /// <summary>
        /// Value is contact for user/lead attributes, company for company attributes and conversation for conversation attributes.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }
        /// <summary>
        /// Name of the attribute.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Full name of the attribute. Should match the name unless it's a nested attribute. We can split full_name on .
        /// to access nested user object values.
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        /// <summary>
        /// Readable name of the attribute (i.e. name you see in the UI)
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }
        /// <summary>
        /// Readable description of the attribute.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The data type of the attribute.
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; }
        /// <summary>
        /// List of predefined options for attribute value.
        /// </summary>
        [JsonProperty("options")]
        public string[] Options { get; set; }
        /// <summary>
        /// Can this attribute be updated through API.
        /// </summary>
        [JsonProperty("api_writable")]
        public bool ApiWritable { get; set; }
        /// <summary>
        /// Can this attribute be updated in the UI.
        /// </summary>
        [JsonProperty("ui_writable")]
        public bool UiWritable { get; set; }
        /// <summary>
        /// Set to true if this is a CDA
        /// </summary>
        [JsonProperty("custom")]
        public bool Custom { get; set; }
        /// <summary>
        /// Is this attribute archived. (Only applicable to CDAs)
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// The time the attribute was created as a UTC Unix timestamp
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The time the attribute was last updated as a UTC Unix timestamp
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
