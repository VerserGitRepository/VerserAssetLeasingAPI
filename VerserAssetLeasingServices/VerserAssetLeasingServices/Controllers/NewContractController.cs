using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VerserAssetLeasingServices.API.Models;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;

namespace VerserAssetLeasingServices.API.Controllers
{
    [Route("[controller]")]
    [EnableCors("AllowAll")]
    [ApiController]
    public class NewContractController : ControllerBase
    {
        private INewContract _iNewContract;
        public NewContractController(INewContract icontract)
        {
            _iNewContract = icontract;
        }

        [HttpPost]
        
        [Route("CreateNewContract")]
        public IActionResult AddNewContract([FromBody] NewContractModel AddNewcontractRequest)
        {
            ReturnModel returnmessage = new ReturnModel();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            ContractsDto NewContractData = AddNewContractData(AddNewcontractRequest);
           bool isValidContract= _iNewContract.AddNewContract(NewContractData);
            if (isValidContract !=true)
            {
                return BadRequest();
            }
            returnmessage.Message = "New Contract Created";
            var returnvalue = JsonConvert.SerializeObject(returnmessage);
            return Ok(returnvalue);
        }

        public ContractsDto AddNewContractData(NewContractModel _newcontract)
        {
            ContractsDto DtoTransfer = new ContractsDto
            {
                StartDate = _newcontract.StartDate,
                EndDate = _newcontract.EndDate,
                ServiceNo = _newcontract.ServiceNo,
                Contract_Company = _newcontract.Contract_Company,
                Contract_EndUser=_newcontract.Contract_EndUser,
                Contract_Plan=_newcontract.Contract_Plan
            };

            return DtoTransfer;
        }
    }
}