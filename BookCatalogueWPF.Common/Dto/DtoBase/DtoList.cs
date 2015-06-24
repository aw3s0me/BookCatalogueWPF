using System.Collections.Generic;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
    public class DtoList<T> : DtoBase
    {
        public List<T> Dtos { get; set; } 
    }
}
