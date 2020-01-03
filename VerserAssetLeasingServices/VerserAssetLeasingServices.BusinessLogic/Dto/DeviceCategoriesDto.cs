﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VerserAssetLeasingServices.BusinessLogic.Dto
{
   public class DeviceCategoriesDto
    {
        public int Id { get; set; }
        public string DeviceCategoryName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
    }
}
