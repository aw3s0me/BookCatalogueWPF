using System;
using BookCatalogueWPF.Common.Dto.DtoBase;
using BookCatalogueWPF.Domain.AppServices;
using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.BusinessLayer.Services.BaseServices
{
    public class ServiceBase
    {
        protected TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command)
            where TResult : class, IDtoResponseEnvelope
        {
            using (var transactManager = GlobalContext.Instance().UnitOfWorkFactory.CreateUnitOfWork())
            {
                return transactManager.ExecuteCommand(command);
            }
        }

    }
}
