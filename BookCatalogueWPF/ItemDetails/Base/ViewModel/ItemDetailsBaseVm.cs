using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace BookCatalogueWPF.Client.ItemDetails.Base.ViewModel
{
    public class ItemDetailsBaseVm : ViewModelBase
    {
        //TODO: Обработка Accept и Cancel команд

        private IContent _currentContent;

        public IContent CurrentContent
        {
            get { return _currentContent; }
            set { Set(() => CurrentContent, ref _currentContent, value); }
        }
    }
}
