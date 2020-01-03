using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;

namespace VerserAssetLeasingServices.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private IContracts _Icontracts { get; set; }
        public ContractsController(IContracts icontract) => _Icontracts = icontract;
        [EnableCors("AllowAll")]
        [Route("ContractsList")]

        [HttpGet]
        public IActionResult ContractsList()
        {
            return Ok(_Icontracts.ContractsList());
        }
    }
}