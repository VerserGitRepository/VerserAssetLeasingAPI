using System;
using System.Collections.Generic;
using System.Text;

namespace VerserAssetLeasingServices.DBEntities.EntityModels
{
    public class Contracts
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ServiceNo { get; set; }
        public bool IsCancelled { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
        public int Contract_Company { get; set; }
        public int Contract_EndUser { get; set; }
        public int Contract_Plan { get; set; }      
    }
}
