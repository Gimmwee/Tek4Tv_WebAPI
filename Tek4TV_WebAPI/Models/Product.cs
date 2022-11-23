using System;
using System.Collections.Generic;

namespace Tek4TV_WebAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int IdProduct { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public int? IdCategories { get; set; }

        public virtual Category? IdCategoriesNavigation { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
