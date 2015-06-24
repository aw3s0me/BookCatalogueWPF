using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.Dto.EntityDto
{
    public class CategoryDto : DtoEntityBase
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool HasChildren { get; set; }

        public string ParentId { get; set; }
    }
}
