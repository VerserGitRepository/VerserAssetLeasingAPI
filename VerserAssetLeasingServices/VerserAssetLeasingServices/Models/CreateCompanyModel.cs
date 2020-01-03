using System;
using System.ComponentModel.DataAnnotations;

namespace VerserAssetLeasingServices.API.Models
{
    public class CreateCompanyModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "CompanyName is Mandatory")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "AddressLine1 is Mandatory")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Suburb is Mandatory")]
        public string Suburb { get; set; }
        [Required(ErrorMessage = "State is Mandatory")]
        public string State { get; set; }
        [Required(ErrorMessage = "Postcode is Mandatory")]
        public string Postcode { get; set; }
        [Required(ErrorMessage = "Phone is Mandatory")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is Mandatory")]
        public string Email { get; set; }
        public string Web { get; set; }
        public string Login { get; set; }
        public Nullable<DateTime> ServiceStartDate { get; set; }
        public Nullable<DateTime> ServiceEndDate { get; set; }
        public string CreatedBy { get; set; }
        
        public Nullable<DateTimeOffset> Created { get; set; }     
     
    }
}
