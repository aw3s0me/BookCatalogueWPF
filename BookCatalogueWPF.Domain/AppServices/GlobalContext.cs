using BookCatalogueWPF.Domain.UnitOfWork;

namespace BookCatalogueWPF.Domain.AppServices
{
    public class GlobalContext : IGlobalContext
    {
        private static GlobalContext _instance;

        private GlobalContext()
        {
        }

        public static GlobalContext Instance()
        {
            return _instance ?? (_instance = new GlobalContext());
        }

        public IUnitOfWorkFactory UnitOfWorkFactory { get; set; }
    }
}