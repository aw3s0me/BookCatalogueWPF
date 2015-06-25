﻿using BookCatalogueWPF.Common.Dto.DtoBase;

namespace BookCatalogueWPF.Common.Dto.EntityDto
{
    public class BookDto : DtoEntityBase
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long Year { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Annotation { get; set; }

    }
}
