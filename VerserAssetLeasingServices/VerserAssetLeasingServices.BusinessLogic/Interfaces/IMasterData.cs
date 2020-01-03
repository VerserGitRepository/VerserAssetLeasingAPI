using System;
using System.Collections.Generic;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;

namespace VerserAssetLeasingServices.BusinessLogic.Interfaces
{
  public  interface IMasterData
    {
        IEnumerable<InventoryItemsDto> InventoryItemsList();
        IEnumerable<ColoursDto> ColoursList();
        IEnumerable<CarriersDto> CarriersList();
        IEnumerable<DeviceCategoriesDto> DevicecategoriesList();
        IEnumerable<LifeCycleStatusSetDto> LifeCycleStatusSetList();
        IEnumerable<OEMsDto> OEMsList();
        IEnumerable<PlansDto> PlansList();
        bool TestUpdateColour(UpdateColourDto colourupdate);
    }
}
