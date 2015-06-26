using System;

namespace BookCatalogueWPF.Client.ItemDetails.Helpers
{
    public class RequestCloseEventArgs : EventArgs
    {
        public RequestCloseEventArgs(bool dialogResult)
        {
            DialogResult = dialogResult;
        }

        public bool DialogResult { get; private set; }
    }
}
