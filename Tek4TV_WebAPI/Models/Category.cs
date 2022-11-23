using System;
using System.Collections.Generic;

namespace Tek4TV_WebAPI.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int IdCategories { get; set; }
        public string? NameCategories { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
