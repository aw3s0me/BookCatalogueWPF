using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.BusinessLayer.Services.BaseServices
{
    public class CrudService<TEntity, TDtoEntity> : ServiceBase, ICrudService<TDtoEntity>
        where TEntity : class 
        where TDtoEntity : DtoEntityBase
    {
        public DtoList<TDtoEntity> GetAll()
        {
            return ExecuteCommand(GetAllCommand);
        }

        public TDtoEntity GetById(string id)
        {
            return ExecuteCommand(locator => GetByIdCommand(locator, id));
        }

        protected virtual TDtoEntity GetByIdCommand(IRepositoryLocator locator, string id)
        {
            throw new System.NotImplementedException();
        }

        protected virtual DtoList<TDtoEntity> GetAllCommand(IRepositoryLocator locator)
        {
            var all = locator.GetAll<TEntity>();

            var dtos = new DtoList<TDtoEntity> { Dtos = new List<TDtoEntity>()};

            if (all.Count == 0) return dtos;

            all.ToList().ForEach(x => dtos.Dtos.Add(Mapper.Map<TDtoEntity>(x)));

            return dtos;
        } 

        

    }
}
