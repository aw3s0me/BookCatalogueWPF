using System;
using AutoMapper;
using BookCatalogueWPF.Client.BookServiceReference;
using BookCatalogueWPF.Client.ItemDetails.Base.ViewModel;
using BookCatalogueWPF.Client.ItemDetails.Helpers;
using BookCatalogueWPF.Client.Tree.Item;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.ItemDetails.BookItem.ViewModel
{
    public class BookVm : ViewModelBase, IContent
    {
        public BookVm()
        {}

        public BookVm(CategoryVm category)
        {
            Category = category;
        }

        public BookVm(BookDto dto)
        {
            if (dto != null)
            {
                Mapper.Map(dto, this);
            }
        }

        #region Properties

        #region Year

        private long _year;

        public long Year
        {
            get { return _year; }
            set { Set(() => Year, ref _year, value); }
        }

        #endregion

        #region Publisher

        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set { Set(() => Publisher, ref _publisher, value); }
        }

        #endregion

        #region Title

        private string _title;

        public string Title
        {
            get { return _title; }
            set { Set(() => Title, ref _title, value); }
        }

        #endregion

        #region Author

        private string _author;

        public string Author
        {
            get { return _author; }
            set { Set(() => Author, ref _author, value); }
        }

        #endregion

        #region Annotation

        private string _annotation;

        public string Annotation
        {
            get { return _annotation; }
            set { Set(() => Annotation, ref _annotation, value); }
        }

        #endregion

        public long Id { get; set; }


        #region Category

        public long CategoryId { get; set; }

        public CategoryVm Category { get; set; }

        #endregion


        #endregion

        public event EventHandler<RequestCloseEventArgs> RequestCloseDialog;

        private void InvokeRequestCloseDialog(RequestCloseEventArgs e)
        {
            var handler = RequestCloseDialog;
            if (handler != null)
                handler(this, e);
        }
    }
}
