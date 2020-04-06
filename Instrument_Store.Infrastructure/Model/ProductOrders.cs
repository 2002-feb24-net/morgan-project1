using System;
using System.Collections.Generic;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class ProductOrders
    {
        public int ProductOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
