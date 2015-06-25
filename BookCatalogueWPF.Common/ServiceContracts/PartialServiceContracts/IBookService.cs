using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using System.ServiceModel;

namespace BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts
{
    [ServiceContract]
    public interface IBookService : IGenericService<BookDto>
    {
    }
}