using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.Tree.Item
{
    /// <summary>
    /// TreeViewItem class
    /// </summary>
    public class CategoryVm : ViewModelBase
    {
        #region Constructor

        protected CategoryVm(CategoryVm parent)
        {
            Parent = parent;

            _children = new ObservableCollection<CategoryVm>();

        }

        #endregion

        //TODO: load service property?

        #region Parent

        public CategoryVm Parent { get; protected set; }

        #endregion

        #region Children

        private ObservableCollection<CategoryVm> _children;

        public ObservableCollection<CategoryVm> Children
        {
            get { return _children; }
            set { Set(() => Children, ref _children, value); }
        }

        public void LoadChildren()
        {
            //var children = CategoryService.GetEntitiesForTree();
            //Обработка dto

            throw new NotImplementedException();
        }

        #endregion

        #region IsExpanded

        private bool _isExpanded;

        public bool IsExpanded
        {
            get { return _isExpanded; }
            set { Set(() => IsExpanded, ref _isExpanded, value); }
        }

        #endregion


        #region Name

        private string _name;

        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }

        #endregion


        

    }
}
