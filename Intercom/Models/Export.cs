using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// You can use the API to export data for all messages sent or viewed in a given time frame.
    /// This data will be valuable in analyzing  the performance of your Intercom messages, including all
    /// outbound content types such as Posts, Custom Bots, Emails, Surveys and more.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-data-event-model">Documentation</see>
    /// </summary>
    public class Export
    {
        /// <summary>
        /// The identifier for your job.
        /// </summary>
        [JsonProperty("job_identifier")]
        public string JobIdentifier { get; set; }
        /// <summary>
        /// The current state of your job.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// The location where you can download your data.
        /// </summary>
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }
        /// <summary>
        /// The time after which you will not be able to access the data.
        /// </summary>
        [JsonProperty("download_expires_at")]
        public string DownloadExpiresAt { get; set; }
    }
}
