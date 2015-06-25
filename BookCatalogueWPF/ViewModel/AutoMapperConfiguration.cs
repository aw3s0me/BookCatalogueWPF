
using AutoMapper;
using BookCatalogueWPF.Client.BookServiceReference;
using BookCatalogueWPF.Client.CategoryServiceReference;
using BookCatalogueWPF.Client.Tree.Item;

namespace BookCatalogueWPF.Client.ViewModel
{
    public class AutoMapperConfiguration
    {
        public static void Install()
        {
            #region Book

            //Mapper.CreateMap<BookVm, BookDto>()
            //    .ForMember(dest => dest.Id, otps => otps.MapFrom(src => src.Id));

            //Mapper.CreateMap<BookDto, BookVm>()
            //    .ForMember(dest => dest.Id, otps => otps.MapFrom(src => src.Id));

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
