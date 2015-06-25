using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using BookCatalogueWPF.Domain.Repository;
using Newtonsoft.Json;

namespace BookCatalogueWPF.DataAccessLayer.JSON
{
    public class RepositoryJson<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private List<TEntity> _items = new List<TEntity>();
        private string _storagePath;

        internal RepositoryJson(string storagePath)
        {
            Initialize(storagePath);
        }

        private void Initialize(string storagePath)
        {
            _storagePath = storagePath;

            // Загрузить
            LoadItems();
        }

        private void LoadItems()
        {
            if (!File.Exists(_storagePath)) return;

            using (var sr = new StreamReader(_storagePath))
            {
                _items = JsonConvert.DeserializeObject<List<TEntity>>(sr.ReadToEnd());
            }
        }

        public TEntity GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            return _items;
        }

        public IList<TEntity> SearchBy(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
