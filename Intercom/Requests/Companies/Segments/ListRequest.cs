﻿using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Companies.Segments
{
    public class ListRequest : PlainRequest
    {
        public string Id { get; }

        public ListRequest(Company company)
        {
            Id = company.Id;
        }

        public ListRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"companies/{Id}/segments";
    }
}