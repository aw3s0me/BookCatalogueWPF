using AutoMapper;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Domain.Entities;

namespace BookCatalogueWPF.Domain
{
    public class AutoMapperConfiguration
    {
        public static void Install()
        {


            #region Book

            Mapper.CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Id, otps => otps.MapFrom(src => src.Id));

            Mapper.CreateMap<BookDto, Book>()
                .ForMember(dest => dest.Id, otps => otps.MapFrom(src => src.Id));

            #endregion

            #region Category

            Mapper.CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.Id, otps => otps.MapFrom(src => src.Id));

            Mapper.CreateMap<CategoryDto, Category>()
                .ForMember(dest => dest.Id, otps => otps.MapFrom(src => src.Id));

            #endregion


        }

    }
}
