using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AutoMapper;
using BookCatalogueWPF.BusinessLayer.Services.BaseServices;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts;
using BookCatalogueWPF.Domain.Entities;
using BookCatalogueWPF.Domain.Extensions;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.BusinessLayer.Services.PartialServices
{
    public class BookService: GenericService<Book, BookDto>, IBookService
    {
        private IEnumerable<Category> GetSelfAndChildren(Category category)
        {
            yield return category;
            foreach(var c in category.Children.SelectMany(GetSelfAndChildren))
                yield return c;
        }

        

        public DtoList<BookDto> GetBooksByCategoryIdCommand(IRepositoryLocator locator, long categoryId)
        {
            var dtos = new DtoList<BookDto> {Dtos = new List<BookDto>()};
            var categories = locator.GetAll<Category>();
            var neededCategory = new List<Category>
            {
                categories.FirstOrDefaultFromMany(p => p.Children, p => p.Id == categoryId)
            };
            var recursiveCategories = neededCategory.SelectMany(GetSelfAndChildren);
            var categoriesIds = recursiveCategories.Select(x => x.Id).ToList();

            var entities = locator.GetAll<Book>().Where(x => categoriesIds.Contains(x.CategoryId)).ToList();
            if (entities.Count == 0) return dtos;
            entities.ForEach(x => dtos.Dtos.Add(Mapper.Map<BookDto>(x)));

            return dtos;
        }

        public DtoList<BookDto> GetBooksByCategoryId(long categoryId)
        {
            return ExecuteCommand(locator => GetBooksByCategoryIdCommand(locator, categoryId));
        }
    }
}
