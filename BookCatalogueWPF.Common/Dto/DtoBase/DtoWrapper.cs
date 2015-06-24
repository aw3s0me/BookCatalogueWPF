using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalogueWPF.Common.Dto.DtoBase
{
    public class DtoWrapper<T>: DtoBase
    {
        public T Content { get; set; }
    }
}
