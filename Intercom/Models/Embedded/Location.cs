using Newtonsoft.Json;

namespace Intercom.Models.Embedded
{
    public class Location
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("city_name")]
        public string City { get; set; }
        [JsonProperty("region_name")]
        public string RegionName { get; set; }
        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }
        [JsonProperty("country_name")]
        public string CountryName { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
