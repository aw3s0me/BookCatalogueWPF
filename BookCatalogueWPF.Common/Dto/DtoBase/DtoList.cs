using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
    public class DtoList<T> : DtoBase
    {
        public List<T> Dtos { get; set; } 
    }
}
