using Intercom.Abstractions;
using Intercom.Models.Subscriptions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// A subscription type lets customers easily opt out of non-essential
    /// communications without missing what's important to them.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-subscription-type-model">Documentation</see>
    /// </summary>
    public class Subscription : Model
    {
        /// <summary>
        /// The state of the subscription type.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// A translation object contains the localized details of a subscription type.
        /// </summary>
        [JsonProperty("default_translation")]
        public Translation DefaultTranslation { get; set; }
        /// <summary>
        /// An array of translations objects with the localized version of the subscription type in each
        /// available locale within your translation settings.
        /// </summary>
        [JsonProperty("translations")]
        public IEnumerable<Translation> Translations { get; set; }
        /// <summary>
        /// Describes the type of consent.
        /// </summary>
        [JsonProperty("consent_type")]
        public string ConsentType { get; set; }
    }
}
