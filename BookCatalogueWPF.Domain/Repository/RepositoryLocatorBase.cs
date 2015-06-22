using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookCatalogueWPF.Domain.UnitOfWork;

namespace BookCatalogueWPF.Domain.Repository
{
    public abstract class RepositoryLocatorBase : IRepositoryLocator
    {
        protected Dictionary<Type, object> RepositoryMap = new Dictionary<Type, object>();
        protected abstract IRepository<TEntity> CreateRepository<TEntity>() where TEntity : class; 

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            Type type = typeof (TEntity);

            if (RepositoryMap.Keys.Contains(type))
                return RepositoryMap[type] as IRepository<TEntity>;

            IRepository<TEntity> repository = CreateRepository<TEntity>();

            RepositoryMap.Add(type, repository);

            return repository;
        }

        public TEntity GetById<TEntity>(string id) where TEntity : class
        {
            return GetRepository<TEntity>().GetById(id);
        }

        public IList<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return GetRepository<TEntity>().GetAll();
        }

        public IList<TEntity> SearchBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
