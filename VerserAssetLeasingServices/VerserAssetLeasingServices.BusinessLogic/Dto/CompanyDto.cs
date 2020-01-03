using System;

namespace VerserAssetLeasingServices.BusinessLogic.Dto
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Login { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTime> ServiceStartDate { get; set; }
        public Nullable<DateTime> ServiceEndDate { get; set; }       
        public Nullable<DateTimeOffset> Created { get; set; }
    }
}
