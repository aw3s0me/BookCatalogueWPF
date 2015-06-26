using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using System.ServiceModel;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts
{
    [ServiceContract]
    public interface IBookService : IGenericService<BookDto>
    {
        [OperationContract]
        DtoList<BookDto> GetBooksByCategoryId(long categoryId);

    }
}