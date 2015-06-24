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
        //private static readonly string _storagePath = BookCatalogueWPF.DataAccessLayer.FilePaths.BookFilePath;
        private readonly IRepositoryLocator _repositoryLocator = new RepositoryLocatorJson();

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
