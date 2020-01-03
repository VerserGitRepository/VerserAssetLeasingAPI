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
    public class EndUsersController : ControllerBase
    {
        public IEndUsers _IendUsers { get; set; }
        public EndUsersController(IEndUsers enduser)
        {
            _IendUsers = enduser;
        }
        [EnableCors("AllowAll")]
        [Route("EndUsersList")]
        [HttpGet]
        public IActionResult EndUsersList()
        {
            return Ok(_IendUsers.EndUsersList());
        }
    }
}