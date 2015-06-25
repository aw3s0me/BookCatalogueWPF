using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using BookCatalogueWPF.DataAccessLayer.JSON;
using BookCatalogueWPF.Domain;
using BookCatalogueWPF.Domain.AppServices;

namespace BookCatalogueWPF.WcfService.Factory
{
    public class ServiceFactory : ServiceHostFactory
    {
        private static bool _isInitialized;

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            if (!_isInitialized) InitializeService();
            return base.CreateServiceHost(serviceType, baseAddresses);
        }

        private void InitializeService()
        {
            AutoMapperConfiguration.Install();
            GlobalContext.Instance().UnitOfWorkFactory = new UnitOfWorkFactoryJson();
            _isInitialized = true;
        }

    }
}