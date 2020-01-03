using System.Collections.Generic;
using VerserAssetLeasingServices.DBEntities.EntityModels;
using System.Linq;
using AutoMapper;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.BusinessLogic.Dto;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
    public class DBAccess : IDBAccess
    {
        private AssetLeaseDBContext _context;
        private IMapper _mapper;
        public DBAccess(AssetLeaseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<AssetsDto> GetAssetList()
        {
            var Results= _mapper.Map<List<AssetsDto>>(_context.Assets.ToList());

            //Results = Results.ToList().OrderByDescending(x => x.LastCommissionDate.Value.ToString("dd/MM/yyyy"));
            return Results;
        }
        

    }
}
