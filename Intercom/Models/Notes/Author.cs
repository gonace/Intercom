using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models.Notes
{
    public class Author : Model
    {
        /// <summary>
        /// The name of the author.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The email of the author.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("companies")]
        public IEnumerable<Company> Companies { get; set; }
    }
}
