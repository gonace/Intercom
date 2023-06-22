using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Companies
{
    public class UpdateRequest : PayloadRequest
    {
        public Company Company { get; }

        public UpdateRequest(string id, Company company)
        {
            Company = company;
        }

        public override object Payload => new
        {
            company_id = Company.CompanyId,
            name = Company.Name,
            monthly_spend = Company.MonthlySpend,
            custom_attributes = Company.Attributes,
            plan = Company.Plan?.Name,
            size = Company.Size,
            industry = Company.Industry,
            remote_created_at = Company.RemoteCreatedAt,
            website = Company.Website
        };

        public override string Uri => $"companies/{Company.Id}";
    }
}
