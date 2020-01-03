using System;
using System.Collections.Generic;
using System.Text;

namespace VerserAssetLeasingServices.DBEntities.EntityModels
{
public class InventoryItems
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string InventoryItemID { get; set; }
        public string InventoryItemName { get; set; }
        public string Model { get; set; }
        public int? WarrantyPeriod { get; set; }
        public int? MaintenancePeriod { get; set; }
        public int? SupplierLeadTime { get; set; }
        public int? InventoryItem_Colour { get; set; }
        public int InventoryItem_DeviceCategory { get; set; }
        public int? InventoryItem_FormFactor { get; set; }
        public int InventoryItem_OEM { get; set; }
        public int? InventoryItem_OperatingSystem { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
    }
}
