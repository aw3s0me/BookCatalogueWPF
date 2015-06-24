using BookCatalogueWPF.Domain.UnitOfWork;

namespace BookCatalogueWPF.Domain.AppServices
{
    public interface IGlobalContext
    {
        IUnitOfWorkFactory UnitOfWorkFactory { get; }
    }
}
