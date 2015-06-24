using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;

namespace BookCatalogueWPF.BusinessLayer.Services.BaseServices
{
    public class GenericService<TEntity, TDtoEntity> : CrudService<TEntity, TDtoEntity>, IGenericService<TDtoEntity>
        where TEntity : class 
        where TDtoEntity : DtoEntityBase
    {



        public DtoList<TDtoEntity> GetEntitiesForTreeByParentId(string parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
