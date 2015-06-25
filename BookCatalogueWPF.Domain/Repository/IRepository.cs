using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookCatalogueWPF.Domain.Repository
{
    public interface IRepository<TEntity> where TEntity: class
    {
        #region CRUD empty

        #endregion

        #region Retrieval operations

        TEntity GetById(long id);

        IList<TEntity> GetAll();

        IList<TEntity> SearchBy(Expression<Func<TEntity, bool>> predicate);

        #endregion
    }
}
