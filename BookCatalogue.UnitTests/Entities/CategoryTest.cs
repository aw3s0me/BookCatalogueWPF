using System.Collections.Generic;
using BookCatalogueWPF.DataAccessLayer.JSON;
using BookCatalogueWPF.Domain.Entities;
using BookCatalogueWPF.Domain.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookCatalogue.UnitTests.Entities
{
    [TestClass]
    public class CategoryTest
    {
        private Category _categoryInstance;
        private IList<Category> _categoryListInstance;
        private const string STORAGE_PATH = "C:\\work\\BookCatalogueWPF\\BookCatalogueWPF.WcfService\\App_Data\\categories.json";
        private readonly IRepositoryLocator _repositoryLocator = new RepositoryLocatorJson(STORAGE_PATH);
            
        [TestMethod]
        public void CategoryCrud()
        {
        }

        [TestMethod]
        public void CategoryGetAllEntities()
        {
            _categoryListInstance = _repositoryLocator.GetAll<Category>();

            Assert.IsNotNull(_categoryListInstance);
        }

        [TestMethod]
        public void CategoryGetEntity()
        {

        }

        [TestMethod]
        public void UpdateCategory()
        {

        }
    }
}
