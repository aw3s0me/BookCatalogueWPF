using BookCatalogueWPF.Domain.UnitOfWork;

namespace BookCatalogueWPF.DataAccessLayer.JSON
{
    public class UnitOfWorkJson: UnitOfWorkBase
    {
        public UnitOfWorkJson()
        {
            Locator = new RepositoryLocatorJson();
        }
    }
}
