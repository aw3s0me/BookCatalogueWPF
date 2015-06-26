using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookCatalogueWPF.Domain.Repository
{
    public interface IRepositoryLocator
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        #region Retrieval operations

        //TEntity GetById<TEntity>(Predicate<TEntity> predicate) where TEntity : class;

        IList<TEntity> GetAll<TEntity>() where TEntity : class;

        IList<TEntity> SearchBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;

        #endregion

    }
}
