namespace BookCatalogueWPF.Domain.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork CreateUnitOfWork();
        
    }
}
