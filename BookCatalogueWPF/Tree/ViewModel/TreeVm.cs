using System;
using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using BookCatalogueWPF.Client.CategoryServiceReference;
using BookCatalogueWPF.Client.Tree.Item;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.Tree.ViewModel
{
    public class TreeVm : ViewModelBase
    {
        private CategoryServiceClient _treeService = new CategoryServiceClient();

        public TreeVm()
        {
            _treeRootCollection = new ObservableCollection<CategoryVm>();
            var elements = _treeService.GetFirstLevelTreeElements();
            elements.Dtos.ToList().ForEach(x => _treeRootCollection.Add(new CategoryVm(x)));
        }

        #region TreeRootCollection

        private ObservableCollection<CategoryVm> _treeRootCollection;

        public ObservableCollection<CategoryVm> TreeRootCollection
        {
            get { return _treeRootCollection ?? (_treeRootCollection = new ObservableCollection<CategoryVm>()); }
        }

        #endregion


    }
}
