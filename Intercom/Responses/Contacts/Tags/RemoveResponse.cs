﻿using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Responses.Contacts.Tags
{
    public class RemoveResponse : Model
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
