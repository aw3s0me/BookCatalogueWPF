using System;
using System.Collections.ObjectModel;
using AutoMapper;
using BookCatalogueWPF.Client.CategoryServiceReference;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.Tree.Item
{
    /// <summary>
    /// TreeViewItem class
    /// </summary>
    public class CategoryVm : ViewModelBase
    {
        #region Constructor

        public CategoryVm()
        {
            Init();
            Parent = null;
            
        }

        public CategoryVm(CategoryVm parent)
        {
            Init();
            Parent = parent;
            
        }

        public CategoryVm(CategoryDto dto)
        {
            Init();
            if (dto != null)
            {
                Mapper.Map(dto, this);
            }
        }

        private void Init()
        {
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
            //Обработка dto Lazy Load

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

        #region IsSelected

        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set { Set(() => IsSelected, ref _isSelected, value); }
        }

        #endregion


        #region Dto Properties

        private string _name;

        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }

        private bool _hasChildren;

        public bool HasChildren
        {
            get { return _hasChildren; }
            set { Set(() => HasChildren, ref _hasChildren, value); }
        }

        private long _id;

        public long Id
        {
            get { return _id; }
            set { Set(() => Id, ref _id, value); }
        }

        private long? _parentId;

        public long? ParentId
        {
            get { return _parentId; }
            set { Set(() => ParentId, ref _parentId, value); }
        }

        #endregion




    }
}
