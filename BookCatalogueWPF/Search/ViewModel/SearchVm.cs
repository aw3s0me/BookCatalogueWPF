using System;
using BookCatalogueWPF.Client.ItemDetails.Base.ViewModel;
using BookCatalogueWPF.Client.ItemDetails.Helpers;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.Search.ViewModel
{
    public class SearchVm : ViewModelBase, IContent
    {
        public event EventHandler<RequestCloseEventArgs> RequestCloseDialog;
    }
}
