using Newtonsoft.Json;

namespace Intercom.Models.Embedded
{
    public class ArticleStatistics
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("views")]
        public int Views { get; set; }
        [JsonProperty("conversions")]
        public int Conversions { get; set; }
        [JsonProperty("reactions")]
        public int Reactions { get; set; }
        [JsonProperty("happy_reaction_precentage")]
        public int HappyReactionPrecentage { get; set; }
        [JsonProperty("netural_reaction_precentage")]
        public int NeturalReactionPrecentage { get; set; }
        [JsonProperty("sad_reaction_precentage")]
        public int SadReactionPrecentage { get; set; }
    }
}
