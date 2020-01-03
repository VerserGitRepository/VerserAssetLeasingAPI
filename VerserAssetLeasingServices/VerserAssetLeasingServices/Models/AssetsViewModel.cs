using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VerserAssetLeasingServices.API.Models
{
    public class AssetsViewModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Asset ID is Required")]
        public string AssetID { get; set; }
        public string SerialNo { get; set; }
        [Required(ErrorMessage = "Asset Company is Required")]
        public int Asset_Company { get; set; }
        public string IMEI { get; set; }
        public string SIMNo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public Nullable<DateTime> PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public Nullable<DateTime> DecomissionDate { get; set; }
        public string Condition { get; set; }
        public decimal? BuyBackPrice { get; set; }
        public Nullable<DateTime> AquisitionDate { get; set; }
        public string SPMD { get; set; }
        public Nullable<DateTime> FirstCommissionDate { get; set; }
        public Nullable<DateTime> LastCommissionDate { get; set; }
        public Nullable<DateTime> LastRepairDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
        public int? Asset_Contract { get; set; }
        public int? Asset_EndUser { get; set; }
        [Required(ErrorMessage = "Asset Status is Required")]
        public int Asset_LifecycleStatus { get; set; }
        [Required(ErrorMessage = "Inventory Item is Required")]
        public int Asset_InventoryItem { get; set; }
        public int? Asset_OSVersion { get; set; }

    }
}
