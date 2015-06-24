using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts;

namespace BookCatalogueWPF.BusinessLayer.Services.PartialServices
{
    public class BookService : IBookService
    {
        DtoList<BookDto> ICrudService<BookDto>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        BookDto IGenericService<BookDto>.GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        DtoList<BookDto> IGenericService<BookDto>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        BookDto ICrudService<BookDto>.GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public DtoList<BookDto> GetEntitiesForTreeByParentId(string parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
