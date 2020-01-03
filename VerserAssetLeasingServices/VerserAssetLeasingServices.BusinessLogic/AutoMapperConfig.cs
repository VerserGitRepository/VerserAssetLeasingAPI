using System;
using System.Collections.Generic;
using System.Text;
using VerserAssetLeasingServices.DBEntities.EntityModels;
using AutoMapper;
using VerserAssetLeasingServices.BusinessLogic.Dto;
//using VerserAssetLeasingServices.

namespace VerserAssetLeasingServices.BusinessLogic
{
    public class AutoMapperConfig 
    {
        public AutoMapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Assets, AssetsDto>();
                cfg.CreateMap<Companies, CompanyDto>();
                cfg.CreateMap<InventoryItems, InventoryItemsDto>();
                cfg.CreateMap<Colours, ColoursDto>();
                cfg.CreateMap<Plans, PlansDto>();
                cfg.CreateMap<Carriers, CarriersDto>();
                cfg.CreateMap<LifecycleStatusSet, LifeCycleStatusSetDto>();
                cfg.CreateMap<OEMs, OEMsDto>();
                cfg.CreateMap<DeviceCategories, DeviceCategoriesDto>();
                cfg.CreateMap<Contracts, ContractsDto>();
            });
        }
    }
}
