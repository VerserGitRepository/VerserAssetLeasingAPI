using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VerserAssetLeasingServices.BusinessLogic.Dto
{
    public class AssetsDto
    {
        public int Id { get; set; }
        public string AssetID { get; set; }
        public string SerialNo { get; set; }
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
     //   [Column(TypeName = "Date")]
        //[DataType(DataType.Date)]
        //[System.ComponentModel.DataAnnotations.DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public Nullable<DateTime> FirstCommissionDate { get; set; }
        public Nullable<DateTime> LastCommissionDate { get; set; }
        public Nullable<DateTime> LastRepairDate { get; set; }
        public string CreatedBy { get; set; }
        //[Column(TypeName = "Date")]
        public Nullable<DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTimeOffset> Modified { get; set; }
        public int? Asset_Contract { get; set; }
        public int? Asset_EndUser { get; set; }
        public int Asset_LifecycleStatus { get; set; }
        public int Asset_InventoryItem { get; set; }
        public int? Asset_OSVersion { get; set; }

    }
}
