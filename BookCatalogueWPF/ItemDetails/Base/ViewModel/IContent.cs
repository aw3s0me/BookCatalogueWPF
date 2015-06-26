using System;
using BookCatalogueWPF.Client.ItemDetails.Helpers;

namespace BookCatalogueWPF.Client.ItemDetails.Base.ViewModel
{
    public interface IContent
    {
        event EventHandler<RequestCloseEventArgs> RequestCloseDialog;
    }
}
