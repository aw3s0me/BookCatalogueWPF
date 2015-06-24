using System;
using System.CodeDom;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.Domain.UnitOfWork
{
    public abstract class UnitOfWorkBase : IUnitOfWork
    {
        protected bool IsInTransaction;

        protected IRepositoryLocator Locator { get; set; }

        private void CheckForWarnings<TResult>(TResult result)
        {
            var response = result as IDtoResponseEnvelope;
            if (response == null) return;
        }

        public void Dispose()
        {
            Dispose(true);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (IsDisposed && IsInTransaction)
            {
                Rollback();
            }

            Locator = null;
            IsDisposed = true;
        }

        public bool IsDisposed { get; set; }

        public TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command) where TResult : class, IDtoResponseEnvelope
        {
            BeginTransaction();
            TResult result = command.Invoke(Locator);
            CommitTransaction();

            return result;

            //TODO: обработка исключения, посылка на клиент
        }

        public void BeginTransaction()
        {
            IsInTransaction = true;
        }

        public void CommitTransaction()
        {
            IsInTransaction = false;
        }

        public void Rollback()
        {
            IsInTransaction = false;
        }
    }
}
