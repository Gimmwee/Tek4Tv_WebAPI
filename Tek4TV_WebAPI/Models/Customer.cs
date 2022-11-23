using System;
using System.Collections.Generic;

namespace Tek4TV_WebAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string UserName { get; set; } = null!;
        public string? PassWord { get; set; }
        public string? NameCustomer { get; set; }
        public int? IsAdmin { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
