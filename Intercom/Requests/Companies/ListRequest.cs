﻿using Intercom.Abstractions;

namespace Intercom.Requests.Companies
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "companies";
    }
}
