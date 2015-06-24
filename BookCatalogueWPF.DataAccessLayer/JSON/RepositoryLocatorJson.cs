using System;
using System.Collections.Generic;
using BookCatalogueWPF.Domain.Entities;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.DataAccessLayer.JSON
{
    public class RepositoryLocatorJson : RepositoryLocatorBase
    {
        //private readonly string _storagePath;

        //public RepositoryLocatorJson(string storagePath)
        //{
        //    _storagePath = storagePath;
        //} 

        public RepositoryLocatorJson() { }

        protected override IRepository<TEntity> CreateRepository<TEntity>(Type type)
        {
            RepositoryJson<TEntity> repo = null;

            var @switch = new Dictionary<Type, Action> {
                { typeof(Category), () => repo = new RepositoryJson<TEntity>(FilePaths.CategoryFilePath) },
                { typeof(Book), () => repo = new RepositoryJson<TEntity>(FilePaths.BookFilePath) }
            };

            @switch[type]();

            if (repo == null) throw new TypeLoadException("Тип для локатора не найден");

            return repo;
        }
    }
}
