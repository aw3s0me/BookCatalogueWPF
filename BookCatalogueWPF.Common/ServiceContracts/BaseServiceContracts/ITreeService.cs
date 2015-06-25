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
        DtoList<T> GetEntitiesForTreeByParentId(long parentId);

        [OperationContract]
        DtoList<T> GetFirstLevelTreeElements();

        //[OperationContract]
        //T GetEntityForTree(string id);
    }
}
