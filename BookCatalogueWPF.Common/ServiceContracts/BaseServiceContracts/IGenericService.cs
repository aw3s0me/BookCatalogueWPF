using System.ServiceModel;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts
{
    [ServiceContract]
    public interface IGenericService<T> : ICrudService<T>, ITreeService<T> where T : DtoEntityBase
    {
        [OperationContract(Name = "GetAllGeneric")]
        DtoList<T> GetAll();

        [OperationContract(Name = "GetByIdGeneric")]
        T GetById(string id);

    }
}