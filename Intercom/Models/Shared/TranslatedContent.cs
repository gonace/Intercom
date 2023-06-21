using Newtonsoft.Json;

namespace Intercom.Models.Shared
{
    public class TranslatedContent
    {
        /// <summary>
        /// The type of object - group_translated_content.
        /// </summary>
        [JsonProperty("type")]
        public virtual string Type { get; set; }


        [JsonProperty("ar")]
        public virtual string Arabic { get; set; }
        [JsonProperty("bg")]
        public virtual string Bengali { get; set; }
        [JsonProperty("bg")]
        public virtual string Bulgarian { get; set; }
        [JsonProperty("bs")]
        public virtual string Bosnian { get; set; }
        [JsonProperty("ca")]
        public virtual string Catalan { get; set; }
        [JsonProperty("cs")]
        public virtual string Czech { get; set; }
        [JsonProperty("da")]
        public virtual string Danish { get; set; }
        [JsonProperty("de")]
        public virtual string German { get; set; }
        [JsonProperty("el")]
        public virtual string Greek { get; set; }
        [JsonProperty("en")]
        public virtual string English { get; set; }
        [JsonProperty("es")]
        public virtual string Spanish { get; set; }
        [JsonProperty("et")]
        public virtual string Estonian { get; set; }
        [JsonProperty("fa")]
        public virtual string Persian { get; set; }
        [JsonProperty("fi")]
        public virtual string Finnish { get; set; }
        [JsonProperty("fr")]
        public virtual string French { get; set; }
        [JsonProperty("he")]
        public virtual string Hebrew { get; set; }
        [JsonProperty("hr")]
        public virtual string Croatian { get; set; }
        [JsonProperty("hu")]
        public virtual string Hungarian { get; set; }
        [JsonProperty("id")]
        public virtual string Indonesian { get; set; }
        [JsonProperty("it")]
        public virtual string Italian { get; set; }
        [JsonProperty("ja")]
        public virtual string Japanese { get; set; }
        [JsonProperty("ko")]
        public virtual string Korean { get; set; }
        [JsonProperty("lt")]
        public virtual string Lithuanian { get; set; }
        [JsonProperty("lv")]
        public virtual string Latvian { get; set; }
        [JsonProperty("mn")]
        public virtual string Mongolian { get; set; }
        [JsonProperty("ms")]
        public virtual string Malay { get; set; }
        [JsonProperty("nb")]
        public virtual string Norwegian { get; set; }
        [JsonProperty("nl")]
        public virtual string Dutch { get; set; }
        [JsonProperty("pl")]
        public virtual string Polish { get; set; }
        [JsonProperty("pt")]
        public virtual string Portuguese { get; set; }
        [JsonProperty("ro")]
        public virtual string Romanian { get; set; }
        [JsonProperty("ru")]
        public virtual string Russian { get; set; }
        [JsonProperty("sl")]
        public virtual string Slovenian { get; set; }
        [JsonProperty("sr")]
        public virtual string Serbian { get; set; }
        [JsonProperty("sv")]
        public virtual string Swedish { get; set; }
        [JsonProperty("th")]
        public virtual string Thai { get; set; }
        [JsonProperty("tr")]
        public virtual string Turkish { get; set; }
        [JsonProperty("uk")]
        public virtual string Ukrainian { get; set; }
        [JsonProperty("vi")]
        public virtual string Vietnamese { get; set; }

        [JsonProperty("pt-BR")]
        public virtual string BrazilPortuguese { get; set; }
        [JsonProperty("zh-CN")]
        public virtual string ChineseSimplified { get; set; }
        [JsonProperty("zh-TW")]
        public virtual string ChineseTraditional { get; set; }
    }
}
