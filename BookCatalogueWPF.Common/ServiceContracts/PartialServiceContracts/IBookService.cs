using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;

namespace BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts
{
    public interface IBookService : IGenericService<BookDto>
    {
    }
}