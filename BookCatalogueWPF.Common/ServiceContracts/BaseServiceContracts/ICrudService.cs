using System.ServiceModel;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts
{
    [ServiceContract]
    public interface ICrudService<T> where T : DtoEntityBase
    {
        [OperationContract]
        DtoList<T> GetAll();

        [OperationContract]
        T GetById(string id);


    }
}