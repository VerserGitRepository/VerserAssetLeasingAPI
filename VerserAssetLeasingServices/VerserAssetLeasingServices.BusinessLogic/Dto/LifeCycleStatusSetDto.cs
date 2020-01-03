using System;
using System.Collections.Generic;
using System.Text;

namespace VerserAssetLeasingServices.BusinessLogic.Dto
{
   public class LifeCycleStatusSetDto
    {
        public int Id { get; set; }
        public string LifecycleStatusName { get; set; }
        public int SortOrder { get; set; }
        public bool AssetsAreAvailable { get; set; }
        public bool AssetsAreAllocated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }

    }
}
