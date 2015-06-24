using System.Runtime.Serialization;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
    [DataContract]
    public class DtoEntityBase : DtoBase
    {
        [DataMember]
        public long Id { get; set; }

    }
}
