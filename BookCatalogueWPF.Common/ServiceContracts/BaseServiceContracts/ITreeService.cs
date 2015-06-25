using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.ServiceContracts.BaseServiceContracts
{
    [ServiceContract]
    public interface ITreeService<T> where T : DtoEntityBase
    {
        [OperationContract]
        DtoList<T> GetEntitiesForTreeByParentId(string parentId);

        //[OperationContract]
        //T GetEntityForTree(string id);
    }
}
