using System;
using System.Collections.Generic;

namespace Tek4TV_WebAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int OrderId { get; set; }
        public string? UserName { get; set; }
        public double? Total { get; set; }
        public int? IsPay { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Customer? UserNameNavigation { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
