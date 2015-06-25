using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace BookCatalogueWPF.Client.Tree.Helpers
{
    public abstract class CollectionBaseVm<T> : ViewModelBase
        where T : ViewModelBase
    {
        private readonly ObservableCollection<T> _items;

        public ObservableCollection<T> Items
        {
            get { return _items; }
        }

        public CollectionBaseVm()
        {
            _items = new ObservableCollection<T>();
        }

        private ICommand _loadItemsCommand;

        public ICommand LoadItemsCommand
        {
            get { return _loadItemsCommand = _loadItemsCommand ?? new RelayCommand(LoadItems); }
        }

        protected abstract void LoadItems();

    }
}
