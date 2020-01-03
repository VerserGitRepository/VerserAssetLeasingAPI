using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;
using VerserAssetLeasingServices.Common.Implementation;
//using VerserAssetLeasingServices.Common.Interfaces;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
   public class AssetsService :IAssets
    {
        private AssetLeaseDBContext  _context { get; set; }
        // private ILogs _WriteErrorlog { get; set; }
        private Logs _WriteErrorlog = new Logs();
        public AssetsService(AssetLeaseDBContext context)//, ILogs log)
        {
            _context = context;
             //_WriteErrorlog = log;
        }
        public bool AddNewAsset(AssetsDto asset)
        {
            try
            {
                var assetExist = _context.Assets.Where(x => x.AssetID == asset.AssetID).FirstOrDefault();
                if (assetExist !=null)
                {
                    return false;
                }
                Assets newAsset = new Assets
                {
                    AssetID = asset.AssetID,
                    Asset_Company = asset.Asset_Company,
                    Asset_Contract = asset.Asset_Contract,
                    IMEI = asset.IMEI,
                    SerialNo = asset.SerialNo,
                    SIMNo = asset.SIMNo,
                    SPMD = asset.SPMD,
                    FirstCommissionDate = asset.FirstCommissionDate,
                    LastCommissionDate = asset.LastCommissionDate,
                    BuyBackPrice = asset.BuyBackPrice,
                    PurchaseOrderNo = asset.PurchaseOrderNo,
                    PurchaseDate = asset.PurchaseDate,
                    Condition = asset.Condition,
                    AquisitionDate = asset.AquisitionDate,
                    Asset_EndUser = asset.Asset_EndUser,
                    Asset_InventoryItem = asset.Asset_InventoryItem,
                    Asset_LifecycleStatus = asset.Asset_LifecycleStatus,
                    Asset_OSVersion = asset.Asset_OSVersion,
                    CreatedBy = asset.CreatedBy,
                    Created = DateTime.Now
                };
                _context.Assets.Add(newAsset);
                _context.SaveChanges();
            }
            catch (Exception Ex)
            {
               
               _WriteErrorlog.WrireErrorLogs(Ex.Message.ToString());
                return false;
            }
            return true;
        }
    }
}
