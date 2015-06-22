using BookCatalogueWPF.Domain.Repository;

namespace BookCatalogueWPF.DataAccessLayer.JSON
{
    public class RepositoryLocatorJson : RepositoryLocatorBase
    {
        private readonly string _storagePath;

        public RepositoryLocatorJson(string storagePath)
        {
            _storagePath = storagePath;
        } 

        protected override IRepository<TEntity> CreateRepository<TEntity>()
        {
            return new RepositoryJson<TEntity>(_storagePath);
        }
    }
}
