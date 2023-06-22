using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

namespace Intercom.Requests.Companies
{
    /// <summary>
    /// You can create or update a company.
    ///
    /// Companies are looked up via company_id in a POST
    /// request, if not found via company_id, the new
    /// company will be created, if found, that company
    /// will be updated.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createorupdatecompany">Documentation</see>
    /// </summary>
    public class UpsertRequest : PayloadRequest
    {
        /// <summary>
        /// The company id you have defined for the company.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The name of the Company.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The name of the plan you have associated with
        /// the company.
        /// </summary>
        public string Plan { get; set; }
        /// <summary>
        /// The number of employees in this company.
        /// </summary>
        public int? Size { get; set; }
        /// <summary>
        /// The URL for this company's website.
        /// Please note that the value specified here is not validated.
        ///
        /// Accepts any string.
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// The industry that this company operates in.
        /// </summary>
        public string Industry { get; set; }
        /// <summary>
        /// A hash of key/value pairs containing any other data
        /// about the company you want Intercom to store.
        /// </summary>
        public Dictionary<string, object> Attributes { get; set; }
        /// <summary>
        /// The time the company was created by you.
        /// </summary>
        public long? RemoteCreatedAt { get; set; }
        /// <summary>
        /// How much revenue the company generates for your business.
        /// Note that this will truncate floats.
        ///
        /// i.e. it only allow for whole integers, 155.98 will
        /// be truncated to 155.
        ///
        /// Note that this has an upper limit of 2**31-1 or 2147483647..
        /// </summary>
        public decimal? MonthlySpend { get; set; }

        public UpsertRequest(Company company)
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

        public UpsertRequest(string name)
        {
            Name = name;
        }

        public override object Payload => new
        {
            company_id = Id,
            name = Name,
            plan = Plan,
            size = Size,
            website = Website,
            industry = Industry,
            custom_attributes = Attributes,
            remote_created_at = RemoteCreatedAt,
            monthly_spend = MonthlySpend
        };

        public override string Uri => "companies";
    }
}
