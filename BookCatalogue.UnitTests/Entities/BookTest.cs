using System.Collections.Generic;
using BookCatalogueWPF.DataAccessLayer.JSON;
using BookCatalogueWPF.Domain.Entities;
using BookCatalogueWPF.Domain.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookCatalogue.UnitTests.Entities
{
    [TestClass]
    public class BookTest
    {
        private Book _bookInstance;
        private IList<Book> _bookListInstance;
        private const string STORAGE_PATH = "C:\\work\\BookCatalogueWPF\\BookCatalogueWPF.WcfService\\App_Data\\books.json";
        private readonly IRepositoryLocator _repositoryLocator = new RepositoryLocatorJson(STORAGE_PATH);

        [TestMethod]
        public void BookCrud()
        {
        }

        [TestMethod]
        public void BookGetAllEntities()
        {
            _bookListInstance = _repositoryLocator.GetAll<Book>();

            Assert.IsNotNull(_bookListInstance);
        }

        [TestMethod]
        public void BookGetEntity()
        {
            
        }

        [TestMethod]
        public void UpdateBook()
        {
            
        }
    }
}
