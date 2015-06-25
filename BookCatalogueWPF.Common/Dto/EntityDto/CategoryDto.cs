using System.Runtime.Serialization;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.Dto.EntityDto
{
    public class CategoryDto : DtoEntityBase
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        public bool HasChildren { get; set; }

        public long? ParentId { get; set; }
    }
}
