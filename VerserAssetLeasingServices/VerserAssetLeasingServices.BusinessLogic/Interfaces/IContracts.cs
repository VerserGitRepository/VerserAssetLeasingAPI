using System;
using System.Collections.Generic;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;

namespace VerserAssetLeasingServices.BusinessLogic.Interfaces
{
    public interface IContracts
    {
        IEnumerable<ContractsDto> ContractsList();
    }
}
