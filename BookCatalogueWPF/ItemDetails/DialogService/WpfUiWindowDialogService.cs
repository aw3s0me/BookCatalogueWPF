using System.Threading;
using BookCatalogueWPF.Client.ItemDetails.Base.View;
using BookCatalogueWPF.Client.ItemDetails.BookItem.View;

namespace BookCatalogueWPF.Client.ItemDetails.DialogService
{
    public class WpfUiWindowDialogService : IUiWindowDialogService
    {
        public bool? ShowOneThreadedDialog(object datacontext)
        {
            var window = new ItemDetailsBaseView {DataContext = datacontext};

            return window.ShowDialog();
        }

        public void ShowMultiThreadedDialog(object datacontext)
        {
            var thread = new Thread(() =>
            {
                var window = new ItemDetailsBaseView { DataContext = datacontext };
                window.Show();

                window.Closed += (sender2, e2) =>
                window.Dispatcher.InvokeShutdown();

                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

    }
}
