using System;
using BookCatalogueWPF.Domain.UnitOfWork;

namespace BookCatalogueWPF.DataAccessLayer.JSON
{
    public class UnitOfWorkFactoryJson : IUnitOfWorkFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            return new UnitOfWorkJson();

            //switch (type.Name)
            //{
            //    case "Book":
            //        return new UnitOfWorkJson(FilePaths.BookFilePath);
            //    case "Category":
            //        return new UnitOfWorkJson(FilePaths.CategoryFilePath);
            //    default:
            //        return null;
            //}
        }
    }
}
