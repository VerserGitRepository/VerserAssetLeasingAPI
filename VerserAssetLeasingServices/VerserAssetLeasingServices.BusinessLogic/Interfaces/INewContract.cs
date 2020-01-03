using System;
using System.Collections.Generic;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;

namespace VerserAssetLeasingServices.BusinessLogic.Interfaces
{
    public interface INewContract
    {
        bool AddNewContract(ContractsDto newContractRequest);
    }
}
