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
        //private static string _storagePath = BookCatalogueWPF.DataAccessLayer.FilePaths.CategoryFilePath;
        private readonly IRepositoryLocator _repositoryLocator = new RepositoryLocatorJson();
            
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
