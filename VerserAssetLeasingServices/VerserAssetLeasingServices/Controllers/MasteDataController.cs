using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.BusinessLogic.Dto;
namespace VerserAssetLeasingServices.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MasteDataController : ControllerBase
    {
        private IMasterData _masterDataContext{ get; set; }
        public MasteDataController(IMasterData _masterdatacontext)
        {
            this._masterDataContext = _masterdatacontext;
        }
        [HttpGet]
        [Route("InventoryItems")]
        public IActionResult InventoryItems()
        {
            var Inventories = _masterDataContext.InventoryItemsList();
            return Ok(Inventories);
        }
        [HttpGet]
        [Route("Colours")]
        public IActionResult Colours()
        {
            var colours = _masterDataContext.ColoursList();
            return Ok(colours);
        }
        [HttpPost]
        [Route("UpdateColour")]
        public IActionResult UpdateColour( [FromBody] UpdateColourDto colourupdate )
        {
            var colours = _masterDataContext.TestUpdateColour(colourupdate);
           // bool TestUpdateColour(int id, string colour);
            return Ok(colours);
        }
        [HttpGet]
        [Route("CarriersList")]
        public IActionResult CarriersList()
        {
            var colours = _masterDataContext.CarriersList();
            return Ok(colours);
        }
        [HttpGet]
        [Route("PlansList")]
        public IActionResult PlansList()
        {
            var colours = _masterDataContext.PlansList();
            return Ok(colours);
        }
        [HttpGet]
        [Route("LifeCycleStatusSetList")]
        public IActionResult LifeCycleStatusSetList()
        {
            var colours = _masterDataContext.LifeCycleStatusSetList();
            return Ok(colours);
        }
        [HttpGet]
        [Route("OEMsList")]
        public IActionResult OEMsList()
        {
            var colours = _masterDataContext.OEMsList();
            return Ok(colours);
        }
        [HttpGet]
        [Route("DevicecategoriesList")]
        public IActionResult DevicecategoriesList()
        {
            var colours = _masterDataContext.DevicecategoriesList();
            return Ok(colours);
        }
    }
}