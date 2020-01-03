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
    [ApiController]
    [EnableCors("AllowAll")]
    public class CreateEndUsersController : ControllerBase
    {
        private ICreateEndUsers _EndUsers;
        public CreateEndUsersController(ICreateEndUsers endUserCreate)
        {
            _EndUsers = endUserCreate;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult CreateEndUsers([FromBody] CreateEndUserModel createUserModel)
        {
            ReturnModel returnmessage = new ReturnModel();
            if (!ModelState.IsValid==true)
            {
                return BadRequest();
            }
            EndUsersDto newUserData = CreateNewUserData(createUserModel);
            bool IsUserCreated= _EndUsers.CreateNewEndUser(newUserData);
            if (IsUserCreated!=true)
            {
                return BadRequest();
            }
            returnmessage.Message = "EndUser Created";
            var returnvalue = JsonConvert.SerializeObject(returnmessage);
            return Ok(returnvalue);           
        }
        private static EndUsersDto CreateNewUserData(CreateEndUserModel createUser)
        {
            EndUsersDto createUserDto = new EndUsersDto
            {
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                EmployeeNo = createUser.EmployeeNo,
                Department = createUser.Department,
                CostCode = createUser.CostCode,
                EndUserStatus = createUser.EndUserStatus,
                CommencementDate = createUser.CommencementDate,
                TerminationDate = createUser.TerminationDate,
                EndUser_Company = createUser.EndUser_Company,
                EndUser_Site = createUser.EndUser_Site,
                Created = DateTimeOffset.Now                
            };
            return createUserDto;
        }
    }
}