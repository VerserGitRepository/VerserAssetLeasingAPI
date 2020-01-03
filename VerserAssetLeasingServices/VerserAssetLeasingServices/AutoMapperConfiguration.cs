using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.API.Models;
namespace VerserAssetLeasingServices.API
{
    public class AutoMapperConfiguration 
    {
        public AutoMapperConfiguration()
        {
            Mapper.Initialize(cfg =>
            {               
                cfg.CreateMap<CreateCompanyModel, CompanyDto>();
            });
        }
    }
}
