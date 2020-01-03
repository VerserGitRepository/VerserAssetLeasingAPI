using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
    public class NewContractService :INewContract
    {
        private readonly AssetLeaseDBContext _Context;
        public NewContractService(AssetLeaseDBContext context)
        {
            _Context = context;
        }
        public  bool AddNewContract(ContractsDto newContractRequest)
        {
            try
            {
                var IsContractExists = _Context.Contracts.Where(x => x.ServiceNo == newContractRequest.ServiceNo
            && x.Contract_Company == newContractRequest.Contract_Company
            && x.Contract_EndUser == newContractRequest.Contract_EndUser
            && x.Contract_Plan == newContractRequest.Contract_Plan).FirstOrDefault();
                if (IsContractExists != null)
                {
                    return false;
                }
                Contracts addNewContract = new Contracts
                {
                    ServiceNo = newContractRequest.ServiceNo,
                    StartDate = newContractRequest.StartDate,
                    EndDate = newContractRequest.EndDate,
                    Contract_Company = newContractRequest.Contract_Company,
                    Contract_EndUser = newContractRequest.Contract_EndUser,
                    Contract_Plan = newContractRequest.Contract_Plan,
                    Created = DateTimeOffset.Now,
                    CreatedBy = newContractRequest.CreatedBy
                };
                _Context.Contracts.Add(addNewContract);
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                   return false;
            }            
            return true;
        }
    }
}
