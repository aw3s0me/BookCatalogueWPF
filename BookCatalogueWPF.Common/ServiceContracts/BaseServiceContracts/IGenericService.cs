using System.ServiceModel;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts
{
    [ServiceContract]
    public interface IGenericService<T> : ICrudService<T>, ITreeService<T> where T : DtoEntityBase
    {
        //[OperationContract]
        //DtoList<T> GetAll();

        //[OperationContract]
        //T GetById(string id);

    }
}