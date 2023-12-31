﻿using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Responses.Contacts
{
    public class ListResponse : PageableResponse<Contact>
    {
        [JsonProperty("data")]
        public override IEnumerable<Contact> Data { get; set; }
    }
}
