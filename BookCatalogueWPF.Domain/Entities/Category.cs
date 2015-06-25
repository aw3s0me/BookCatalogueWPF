﻿using System;
using System.Collections.Generic;

namespace BookCatalogueWPF.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            Children = new List<Category>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Category> Children { get; set; }

        public Category ParentCategory { get; set; }

    }
}
