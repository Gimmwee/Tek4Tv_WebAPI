using System;
using System.Collections.Generic;

namespace Tek4TV_WebAPI.Models
{
    public partial class OrdersDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
