using System;
using System.ComponentModel.DataAnnotations;

namespace VerserAssetLeasingServices.API.Models
{
    public class CreateEndUserModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="First Name is Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required!")]
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
        [Required]
        public int EndUser_Company { get; set; }
        public int? EndUser_Site { get; set; }
    }
}
