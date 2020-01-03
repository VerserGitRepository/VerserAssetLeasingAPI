using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;
using AutoMapper;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
    public class CompanyService : ICompany
    {
        private AssetLeaseDBContext _context { get; set; }
        private IMapper _mapper;
        public CompanyService(AssetLeaseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public  IEnumerable<CompanyDto> CompanyList()
        {
            return _mapper.Map<IEnumerable<CompanyDto>>( _context.Companies.ToList().OrderByDescending(x=>x.CompanyName));             
        }

    }
}
