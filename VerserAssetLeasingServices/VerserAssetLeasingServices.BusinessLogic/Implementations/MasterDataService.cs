using System;
using System.Collections.Generic;
using System.Linq;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;
using AutoMapper;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
 public class MasterDataService :IMasterData
    {
        private AssetLeaseDBContext _Context;
        private IMapper _Mapper;
        public MasterDataService(AssetLeaseDBContext context, IMapper _mapper)
        {
            _Context = context;
            _Mapper = _mapper;
        }
        public IEnumerable<InventoryItemsDto> InventoryItemsList()
        {
            return (_Mapper.Map<IEnumerable<InventoryItemsDto>>(_Context.InventoryItems.ToList().OrderByDescending(x => x.InventoryItemName)));
        }
        public IEnumerable<ColoursDto> ColoursList()
        {
            return (_Mapper.Map<IEnumerable<ColoursDto>>(_Context.Colours.ToList().OrderByDescending(x => x.ColourName)));
        }

        public bool TestUpdateColour(UpdateColourDto colourupdate)
        {
            try
            {
                var updateColourObj = _Context.Colours.Where(x => x.Id == colourupdate.Id).FirstOrDefault();
                updateColourObj.ColourName = colourupdate.Colour;
                _Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }           
        }

        public IEnumerable<CarriersDto> CarriersList()
        {
            return (_Mapper.Map<IEnumerable<CarriersDto>>(_Context.Carriers.ToList().OrderByDescending(x => x.CarrierName)));
        }
        public IEnumerable<DeviceCategoriesDto> DevicecategoriesList()
        {
            return (_Mapper.Map<IEnumerable<DeviceCategoriesDto>>(_Context.DeviceCategories.ToList().OrderByDescending(x => x.DeviceCategoryName)));
        }
        public IEnumerable<LifeCycleStatusSetDto> LifeCycleStatusSetList()
        {
            return (_Mapper.Map<IEnumerable<LifeCycleStatusSetDto>>(_Context.LifecycleStatusSet.ToList().OrderByDescending(x => x.LifecycleStatusName)));
        }
        public IEnumerable<OEMsDto> OEMsList()
        {
            return (_Mapper.Map<IEnumerable<OEMsDto>>(_Context.OEMs.ToList().OrderByDescending(x => x.OEMName)));
        }
        public IEnumerable<PlansDto> PlansList()
        {
            return (_Mapper.Map<IEnumerable<PlansDto>>(_Context.Plans.ToList().OrderByDescending(x => x.PlanName)));
        }

    }
}
