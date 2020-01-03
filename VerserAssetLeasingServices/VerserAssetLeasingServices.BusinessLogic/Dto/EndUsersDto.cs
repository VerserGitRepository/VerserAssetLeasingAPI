using System;

namespace VerserAssetLeasingServices.BusinessLogic.Dto
{
    public class EndUsersDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeNo { get; set; }
        public string Department { get; set; }
        public string CostCode { get; set; }
        public string EndUserStatus { get; set; }
        public Nullable<DateTime> CommencementDate { get; set; }
        public Nullable<DateTime> TerminationDate { get; set; }
        public string UserName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
        public int EndUser_Company { get; set; }
        public int? EndUser_Site { get; set; }
    }
}
