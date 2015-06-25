using System.ServiceModel;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;

namespace BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts
{
    [ServiceContract]
    public interface ICategoryService : IGenericService<CategoryDto>
    {

    }
}