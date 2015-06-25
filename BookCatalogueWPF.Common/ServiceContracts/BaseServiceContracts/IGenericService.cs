using System.ServiceModel;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts
{
    [ServiceContract]
    public interface IGenericService<T> : ICrudService<T> where T : DtoEntityBase
    {
        //TODO: здесь методы по работе с деревом и сущности к-ые входят в состав дерева, также возможно переопределение методов Crud

        //[OperationContract]
        //DtoList<T> GetAll();

        //[OperationContract]
        //T GetById(string id);

    }
}