/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:BookCatalogueWPF.Client"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using BookCatalogueWPF.Client.Grid.ViewModel;
using BookCatalogueWPF.Client.ItemDetails.Base.ViewModel;
using BookCatalogueWPF.Client.Tree.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BookCatalogueWPF.Client.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}


            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<TreeVm>();
            SimpleIoc.Default.Register<BookGridVm>();
            SimpleIoc.Default.Register<ItemDetailsBaseVm>();

            //TODO: добавить Search
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public static TreeVm Tree
        {
            get { return ServiceLocator.Current.GetInstance<TreeVm>(); }
        }

        public static BookGridVm BookGrid
        {
            get { return ServiceLocator.Current.GetInstance<BookGridVm>(); }
        }

        public static ItemDetailsBaseVm ItemDetails
        {
            get { return ServiceLocator.Current.GetInstance<ItemDetailsBaseVm>(); }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}