using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
    public class EndUsersService :IEndUsers
    {
        private AssetLeaseDBContext _context;
        private IMapper _mapper;
        public EndUsersService(AssetLeaseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }           
        public IEnumerable<EndUsersDto> EndUsersList()
        {
            return _mapper.Map<IEnumerable<EndUsersDto>>(_context.EndUsers.ToList().OrderByDescending(x=>x.FirstName));
        }

    }
}
