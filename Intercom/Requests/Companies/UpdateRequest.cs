using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

namespace Intercom.Requests.Companies
{
    /// <summary>
    /// You can update a single company
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/updatecompany">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The company id you have defined for the company.
        /// </summary>
        public string Id { get; } = null;
        /// <summary>
        /// The name of the Company.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The name of the plan you have associated with
        /// the company.
        /// </summary>
        public string Plan { get; }
        /// <summary>
        /// The number of employees in this company.
        /// </summary>
        public int? Size { get; }
        /// <summary>
        /// The URL for this company's website.
        /// Please note that the value specified here is not validated.
        ///
        /// Accepts any string.
        /// </summary>
        public string Website { get; }
        /// <summary>
        /// The industry that this company operates in.
        /// </summary>
        public string Industry { get; }
        /// <summary>
        /// A hash of key/value pairs containing any other data
        /// about the company you want Intercom to store.
        /// </summary>
        public Dictionary<string, object> Attributes { get; }
        /// <summary>
        /// The time the company was created by you.
        /// </summary>
        public long? RemoteCreatedAt { get; }
        /// <summary>
        /// How much revenue the company generates for your business.
        /// Note that this will truncate floats.
        ///
        /// i.e. it only allow for whole integers, 155.98 will
        /// be truncated to 155.
        ///
        /// Note that this has an upper limit of 2**31-1 or 2147483647..
        /// </summary>
        public decimal? MonthlySpend { get; }

        public UpdateRequest(Company company)
        {
            Id = company.Id;
            Name = company.Name;
            Plan = company.Plan?.Name;
            Size = company.Size;
            Website = company.Website;
            Industry = company.Industry;
            Attributes = company.Attributes;
            RemoteCreatedAt = company.RemoteCreatedAt;
            MonthlySpend = company.MonthlySpend;
        }

        public override object Payload => new
        {
            name = Name,
            plan = Plan,
            size = Size,
            website = Website,
            industry = Industry,
            custom_attributes = Attributes,
            remote_created_at = RemoteCreatedAt,
            monthly_spend = MonthlySpend
        };

        public override string Uri => $"companies/{Id}";
    }
}
