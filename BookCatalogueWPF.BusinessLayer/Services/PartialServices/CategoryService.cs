using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BookCatalogueWPF.BusinessLayer.Services.BaseServices;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Common.Dto.EntityDto;
using BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts;
using BookCatalogueWPF.Common.ServiceContracts.PartialServiceContracts;
using BookCatalogueWPF.Domain.Entities;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.BusinessLayer.Services.PartialServices
{
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {
        #region GetEntitiesForTreeByParentId

        public DtoList<CategoryDto> GetEntitiesForTreeByParentId(long parentId)
        {
            return ExecuteCommand(locator => GetEntitiesForTreeByParentIdCommand(locator, parentId));
        }

        private DtoList<CategoryDto> GetEntitiesForTreeByParentIdCommand(IRepositoryLocator locator, long parentId)
        {
            var dtos = new DtoList<CategoryDto> {Dtos = new List<CategoryDto>()};

            var entities = locator.SearchBy<CategoryDto>(parent => parent.Id == parentId);

            if (entities.Count == 0) return dtos;
            entities.ToList().ForEach(x => dtos.Dtos.Add(Mapper.Map<CategoryDto>(x)));

            return dtos;
        }

        #endregion

        public DtoList<CategoryDto> GetFirstLevelTreeElements()
        {
            return ExecuteCommand(locator => GetFirstLevelTreeElementsCommand(locator));
        }

        public DtoList<CategoryDto> GetFirstLevelTreeElementsCommand(IRepositoryLocator locator)
        {
            var dtos = new DtoList<CategoryDto> { Dtos = new List<CategoryDto>() };

            //var entities = new List<Category>(locator.GetAll<Category>());
            var entities = locator.GetAll<Category>();

            if (entities.Count == 0) return dtos;
            entities.ToList().ForEach(x =>
            {
                var hasChildren = x.Children.Count != 0;
                x.Children = null;
                var element = Mapper.Map<CategoryDto>(x);
                element.HasChildren = hasChildren;
                dtos.Dtos.Add(element);
            });

            return dtos;
        }
    }
}
