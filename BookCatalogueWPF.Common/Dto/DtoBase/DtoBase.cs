using System.Runtime.Serialization;
using BookCatalogueWPF.Common.Message;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
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
