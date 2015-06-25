using System.Runtime.Serialization;
using System.ServiceModel;
using BookCatalogueWPF.Common.Message;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
    [DataContract]
    [MessageContract]
    public abstract class DtoBase : IDtoResponseEnvelope
    {
        [DataMember]
        private readonly Response _responseInstance = new Response();

        public Response Response
        {
            get { return _responseInstance; }
        }
    }
}
