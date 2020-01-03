using System;
using System.Collections.Generic;
using System.Text;

namespace VerserAssetLeasingServices.DBEntities.EntityModels
{
   public class Carriers
    {
        public int Id { get; set; }
        public string CarrierName { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset Modified { get; set; }     
    }
}
