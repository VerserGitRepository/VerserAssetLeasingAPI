using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VerserAssetLeasingServices.API.Models;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;

namespace VerserAssetLeasingServices.API.Controllers
{
    [Route("[controller]")]

    [ApiController]
    public class CompanyController : ControllerBase
    {
        public ICreateCompany _createCompany { get; private set; }
        public ICompany _Icompany { get; private set; }
        public CompanyController(ICreateCompany icreate, ICompany icompany)
        {
            this._createCompany = icreate;
            _Icompany = icompany;
        }
        [EnableCors("AllowAll")]
       // [AllowAnonymous]
        [Route("Create")]
        [HttpPost]
        public IActionResult CreateCompany([FromBody] CreateCompanyModel createCompany)
        {
            ReturnModel returnmessage = new ReturnModel();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            CompanyDto createDto = CreateCompanyData(createCompany);
            bool isCompanyCreated =_createCompany.CreateCompany(createDto);
            if (!isCompanyCreated)
            {
                return BadRequest();
            }
            returnmessage.Message = "Company Created";

            var returnvalue = JsonConvert.SerializeObject(returnmessage);
            return Ok(returnvalue);
        }
        private static CompanyDto CreateCompanyData(CreateCompanyModel createCompany)
        {
            CompanyDto createDto = new CompanyDto();
            createDto.CompanyName = createCompany.CompanyName;
            createDto.AddressLine1 = createCompany.AddressLine1;
            createDto.Suburb = createCompany.Suburb;
            createDto.State = createCompany.State;
            createDto.Postcode = createCompany.Postcode;
            createDto.Phone =  createCompany.Phone;
            createDto.Email = createCompany.Email;
            createDto.CreatedBy = createCompany.CreatedBy;
            createDto.ServiceStartDate = createCompany.ServiceStartDate;
            createDto.ServiceEndDate = createCompany.ServiceEndDate;
            return createDto;
        }

       [EnableCors("AllowAll")]
        [Route("CompanyList")]
        [HttpGet]
        public IActionResult CompanyList()
        {
            
            return Ok(_Icompany.CompanyList());
        }

    }
}