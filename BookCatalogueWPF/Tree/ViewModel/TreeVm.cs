using System;
using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using BookCatalogueWPF.Client.CategoryServiceReference;
using BookCatalogueWPF.Client.Helpers;
using BookCatalogueWPF.Client.Tree.Item;
using BookCatalogueWPF.Client.ViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BookCatalogueWPF.Client.Tree.ViewModel
{
    public class TreeVm : ViewModelBase
    {
        private CategoryServiceClient _treeService = new CategoryServiceClient();

        public TreeVm()
        {
            _treeRootCollection = new ObservableCollection<CategoryVm>();
            //var elements = _treeService.GetFirstLevelTreeElements();
            var elements = _treeService.GetAll();
            elements.Dtos.ToList().ForEach(x => _treeRootCollection.Add(new CategoryVm(x)));
        }

        #region TreeRootCollection

        private ObservableCollection<CategoryVm> _treeRootCollection;

        public ObservableCollection<CategoryVm> TreeRootCollection
        {
            get { return _treeRootCollection ?? (_treeRootCollection = new ObservableCollection<CategoryVm>()); }
        }

        #endregion

        #region SelectedElement

        private RelayCommand<CategoryVm> _selectElementCommand;


        public RelayCommand<CategoryVm> SelectElementCommand
        {
            get
            {
                return _selectElementCommand ?? (_selectElementCommand = new RelayCommand<CategoryVm>(SelectElement));
            }
        }

        private void SelectElement(CategoryVm selectedItem)
        {
            if (selectedItem == SelectedItem) return;
            SelectedItem = selectedItem;
            //послать мессенджером в BookGrid
            Messenger.Default.Send(new InitBooksMsg() {Category = SelectedItem});
        }

        private CategoryVm _selectedItem;

        public CategoryVm SelectedItem
        {
            get { return _selectedItem; }
            set { Set(() => SelectedItem, ref _selectedItem, value); }
        }

        #endregion
    }
}
