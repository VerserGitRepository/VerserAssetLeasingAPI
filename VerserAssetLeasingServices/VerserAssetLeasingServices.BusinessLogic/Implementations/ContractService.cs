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
  public  class ContractService :IContracts
    {
        private AssetLeaseDBContext _context;
        private readonly IMapper _mapper;

        public ContractService(AssetLeaseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<ContractsDto> ContractsList()
        {
            return _mapper.Map<IEnumerable<ContractsDto>>(_context.Contracts.ToList());
        }
    }
}
