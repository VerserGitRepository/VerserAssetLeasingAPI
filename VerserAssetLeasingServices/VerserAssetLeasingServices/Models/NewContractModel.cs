using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VerserAssetLeasingServices.API.Models
{
    public class NewContractModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string ServiceNo { get; set; }
        public bool IsCancelled { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
        [Required]
        public int Contract_Company { get; set; }
        [Required]
        public int Contract_EndUser { get; set; }
        [Required]
        public int Contract_Plan { get; set; }
    }
}
