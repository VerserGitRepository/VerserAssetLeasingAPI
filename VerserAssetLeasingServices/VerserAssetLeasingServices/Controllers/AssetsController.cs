using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VerserAssetLeasingServices.API.Models;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;

namespace VerserAssetLeasingServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class AssetsController : ControllerBase
    {
        private readonly IDBAccess _dBAccess;
        private readonly IAssets _Iassets;

        public AssetsController(IDBAccess dBAccess, IAssets iasset)
        {
            _dBAccess = dBAccess;
            _Iassets = iasset;
        }
        [Route("SSN")]
        public string TestMethod()
        {
            return JsonConvert.SerializeObject(_dBAccess.GetAssetList());
        }             
              
        [HttpPost]
        [Route("CreateNewAsset")]
        public IActionResult CreateNewAsset([FromBody] AssetsViewModel asset)
        {
            ReturnModel returnmessage = new ReturnModel();
            AssetsDto assetaddData = CreateAssetData(asset);
            bool IsrequestCreated = _Iassets.AddNewAsset(assetaddData);
            returnmessage.Message = "New Asset Created";
            var returnvalue = JsonConvert.SerializeObject(returnmessage);
            return Ok(returnvalue);
        }
        public AssetsDto CreateAssetData(AssetsViewModel assetData)
        {
            AssetsDto newassetdto = new AssetsDto
            {
                AssetID=assetData.AssetID,                
                Asset_Company = assetData.Asset_Company,
                Asset_Contract = assetData.Asset_Contract,
                IMEI = assetData.IMEI,
                SerialNo = assetData.SerialNo,
                SIMNo = assetData.SIMNo,
                SPMD = assetData.SPMD,
                FirstCommissionDate = assetData.FirstCommissionDate,
                LastCommissionDate = assetData.LastCommissionDate,
                BuyBackPrice = assetData.BuyBackPrice,
                PurchaseOrderNo = assetData.PurchaseOrderNo,
                PurchaseDate = assetData.PurchaseDate,
                Condition = assetData.Condition,
                AquisitionDate = assetData.AquisitionDate,
                Asset_EndUser = assetData.Asset_EndUser,
                Asset_InventoryItem = assetData.Asset_InventoryItem,
                Asset_LifecycleStatus = assetData.Asset_LifecycleStatus,
                Asset_OSVersion = assetData.Asset_OSVersion,
                CreatedBy = assetData.CreatedBy
            };
            return newassetdto;
        }
    }
}