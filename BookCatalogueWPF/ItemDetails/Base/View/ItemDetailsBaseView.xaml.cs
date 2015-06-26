using System;
using System.Windows;
using BookCatalogueWPF.Client.ItemDetails.Base.ViewModel;
using BookCatalogueWPF.Client.ItemDetails.Helpers;

namespace BookCatalogueWPF.Client.ItemDetails.Base.View
{
    /// <summary>
    /// Interaction logic for ItemDetailsBaseView.xaml
    /// </summary>
    public partial class ItemDetailsBaseView : Window
    {
        private bool _isClosed = false;

        public ItemDetailsBaseView()
        {
            InitializeComponent();
            //this.DialogPresenter.DataContextChanged += DialogPresenterDataContextChanged;
            this.Closed += DialogWindowClosed;
        }

        private void DialogWindowClosed(object sender, EventArgs e)
        {
            this._isClosed = true;
        }

        private void DialogPresenterDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var d = e.NewValue as IContent;

            if (d == null)
                return;

            //d.RequestCloseDialog +=
            //    new EventHandler<RequestCloseEventArgs>(DialogResultTrueEvent).MakeWeak(
            //        eh => d.RequestCloseDialog -= eh);
        }

        private void DialogResultTrueEvent(object sender, RequestCloseEventArgs eventargs)
        {
            if (_isClosed) return;

            this.DialogResult = eventargs.DialogResult;
        }
    }
}
