using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
    public class CreateEndUsersService :ICreateEndUsers
    {
        AssetLeaseDBContext _Context; 

        public CreateEndUsersService(AssetLeaseDBContext context)
        {
            _Context = context;
        }
        public bool CreateNewEndUser(EndUsersDto NewUserRequest)
        {
            try
            {
                var IsUserExist= _Context.EndUsers.Where(x=>x.FirstName==NewUserRequest.FirstName && x.LastName==NewUserRequest.LastName && x.EndUser_Company==NewUserRequest.EndUser_Company).FirstOrDefault();
                if (IsUserExist !=null)
                {
                    return false;
                }
                EndUsers endUser = new EndUsers
                {
                    FirstName = NewUserRequest.FirstName,
                    LastName = NewUserRequest.LastName,
                    EmployeeNo = NewUserRequest.EmployeeNo,
                    Department = NewUserRequest.Department,
                    CostCode = NewUserRequest.CostCode,
                    EndUserStatus = NewUserRequest.EndUserStatus,
                    CommencementDate = NewUserRequest.CommencementDate,
                    TerminationDate = NewUserRequest.TerminationDate,
                    EndUser_Company = NewUserRequest.EndUser_Company,
                    EndUser_Site = NewUserRequest.EndUser_Site
                };
                _Context.EndUsers.Add(endUser);
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
