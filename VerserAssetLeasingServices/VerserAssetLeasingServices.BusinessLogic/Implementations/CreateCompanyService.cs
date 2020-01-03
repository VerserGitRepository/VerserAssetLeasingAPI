using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.DBEntities.EntityModels;

namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
   public class CreateCompanyService : ICreateCompany
    {
        private AssetLeaseDBContext _context;
        public CreateCompanyService( AssetLeaseDBContext context)
        {
            _context = context;
        }
        public bool CreateCompany(CompanyDto _createcompany)
        {
            try
            {
                string companyName = _createcompany.CompanyName.ToString();                
                Companies IsCompanyExists = _context.Companies.Where(x => x.CompanyName == companyName).FirstOrDefault();
                if (IsCompanyExists != null)
                {
                    return false;
                }
                Companies addNewCompany = new Companies
                {
                    CompanyName = _createcompany.CompanyName,
                    AddressLine1 = _createcompany.AddressLine1,
                    AddressLine2=_createcompany.AddressLine2,
                    Phone = _createcompany.Phone,
                    Suburb = _createcompany.Suburb,
                    Postcode = _createcompany.Postcode,
                    State = _createcompany.State,
                    Email = _createcompany.Email,
                    Created = DateTimeOffset.Now,
                    ServiceStartDate=_createcompany.ServiceStartDate,
                    ServiceEndDate=_createcompany.ServiceEndDate,
                    CreatedBy = _createcompany.CreatedBy
                };
                _context.Add(addNewCompany);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
