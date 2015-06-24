using System;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command)
            where TResult : class, IDtoResponseEnvelope;

        void BeginTransaction();
        void CommitTransaction();
        void Rollback();

    }
}
