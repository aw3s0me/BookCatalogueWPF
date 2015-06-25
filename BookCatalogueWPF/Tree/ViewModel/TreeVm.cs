using System.Collections.ObjectModel;
using BookCatalogueWPF.Client.Tree.Item;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.Tree.ViewModel
{
    public class TreeVm : ViewModelBase
    {
        private ObservableCollection<CategoryVm> _treeRootCollection; 

        public ObservableCollection<CategoryVm> TreeRootCollection
        {
            get
            {
                return _treeRootCollection ?? (_treeRootCollection = new ObservableCollection<CategoryVm>());
            }
        } 

    }
}
