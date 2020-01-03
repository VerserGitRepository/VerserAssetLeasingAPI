using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VerserAssetLeasingServices.BusinessLogic.Dto;
using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.DBEntities.EntityModels;
namespace VerserAssetLeasingServices.BusinessLogic.Implementations
{
   public class ListItemsService :IListItems
    {
        public AssetLeaseDBContext _Context { get; private set; }
        public ListItemsService(AssetLeaseDBContext context)
        {
            this._Context = context;
        }
        //public IEnumerable<ListDto> GetProjectListItems()
        //{
        //    return Mapper.Map<IEnumerable<ListDto>>(_context.Projects.OrderBy(x => x.ProjectName));
        //}
    }
}
