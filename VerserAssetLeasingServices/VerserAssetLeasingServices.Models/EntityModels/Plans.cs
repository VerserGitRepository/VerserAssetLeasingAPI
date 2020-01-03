using System;
using System.Collections.Generic;
using System.Text;

namespace VerserAssetLeasingServices.DBEntities.EntityModels
{
  public class Plans
    {
        public int Id { get; set; }
        public string PlanName { get; set; }
        public decimal MonthyCost { get; set; }
        public int ContractLength { get; set; }        
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
    }
}
