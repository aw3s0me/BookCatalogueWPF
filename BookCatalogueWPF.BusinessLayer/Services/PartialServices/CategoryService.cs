using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts;

namespace BookCatalogueWPF.BusinessLayer.Services.PartialServices
{
    public class CategoryService : ICategoryService
    {
        DtoList<CategoryDto> ICrudService<CategoryDto>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        CategoryDto IGenericService<CategoryDto>.GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        DtoList<CategoryDto> IGenericService<CategoryDto>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        CategoryDto ICrudService<CategoryDto>.GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public DtoList<CategoryDto> GetEntitiesForTreeByParentId(string parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
