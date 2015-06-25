using BookCatalogueWPF.BusinessLayer.Services.BaseServices;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts;
using BookCatalogueWPF.Domain.Entities;

namespace BookCatalogueWPF.BusinessLayer.Services.PartialServices
{
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {
  
    }
}
