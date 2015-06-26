using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalogueWPF.Client.BookServiceReference;
using BookCatalogueWPF.Client.Helpers;
using BookCatalogueWPF.Client.ItemDetails.BookItem.ViewModel;
using BookCatalogueWPF.Client.ItemDetails.DialogService;
using BookCatalogueWPF.Client.Search.ViewModel;
using BookCatalogueWPF.Client.Tree.Item;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BookCatalogueWPF.Client.Grid.ViewModel
{
    public class BookGridVm : ViewModelBase
    {

        private BookServiceClient _bookService = new BookServiceClient();
        private WpfUiWindowDialogService _dialogService = new WpfUiWindowDialogService();

        #region Constructor

        public BookGridVm()
        {
            _books = new ObservableCollection<BookVm>();
            Messenger.Default.Register<InitBooksMsg>(this, PopulateGridWithData);
        }

        #endregion

        #region CurrentCategory

        private CategoryVm _currentCategory;

        public CategoryVm CurrentCategory
        {
            get { return _currentCategory; }
            set { Set(() => CurrentCategory, ref _currentCategory, value); }
        }

        #endregion

        #region Data initialization

        private void PopulateGridWithData(InitBooksMsg msg)
        {
            _books.Clear();
            CurrentCategory = msg.Category;
            var elements = _bookService.GetBooksByCategoryId(CurrentCategory.Id);
            elements.Dtos.ToList().ForEach(x => _books.Add(new BookVm(x)));
        }

        #endregion


        #region Collection

        private ObservableCollection<BookVm> _books;

        public ObservableCollection<BookVm> Books
        {
            get { return _books; }
            set { Set(() => Books, ref _books, value); }
        }

        

        #endregion


        #region OpenDetailsForm

        public RelayCommand<BookVm> MouseDoubleClickCommand
        {
            get
            {
                return _mouseDoubleClickCommand ??
                       (_mouseDoubleClickCommand = new RelayCommand<BookVm>(MouseDoubleClickHandler));
            }

        }

        private RelayCommand _openSearchCommand;
        public object OpenSearchCommand
        {
            get { return _openSearchCommand ?? (_openSearchCommand = new RelayCommand(OpenSearchDialog)); }
        }

        public void OpenSearchDialog()
        {
            _dialogService.ShowOneThreadedDialog(new SearchVm());
        }

        private RelayCommand<BookVm> _mouseDoubleClickCommand;


        private void MouseDoubleClickHandler(BookVm selectedItem)
        {
            var element = selectedItem;

            _dialogService.ShowMultiThreadedDialog(selectedItem);
        }

        #endregion

    }
}
