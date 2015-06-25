using System.Runtime.Serialization;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
    [DataContract]
    public class DtoEntityBase : DtoBase
    {

        //TODO: наследование почему-то создает дубликаты полей
        //[DataMember]
        //public long Id { get; set; }

    }
}
