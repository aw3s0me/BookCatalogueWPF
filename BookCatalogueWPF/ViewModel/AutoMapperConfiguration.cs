
using AutoMapper;
using BookCatalogueWPF.Client.BookServiceReference;
using BookCatalogueWPF.Client.CategoryServiceReference;
using BookCatalogueWPF.Client.ItemDetails.BookItem.ViewModel;
using BookCatalogueWPF.Client.Tree.Item;

namespace BookCatalogueWPF.Client.ViewModel
{
    public class AutoMapperConfiguration
    {
        public static void Install()
        {
            #region Book

            Mapper.CreateMap<BookVm, BookDto>()
                .ReverseMap();

            Mapper.CreateMap<BookDto, BookVm>()
                .ReverseMap();

            #endregion

            #region Category

            Mapper.CreateMap<CategoryVm, CategoryDto>()
                .ReverseMap();

            Mapper.CreateMap<CategoryDto, CategoryVm>()
                .ReverseMap();

            #endregion


        }

    }
}
