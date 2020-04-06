using System;
using System.Collections.Generic;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class Order
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrders>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductOrdersId { get; set; }
        public int StoreId { get; set; }
        public DateTime? Date { get; set; }
        public int? Quantities { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Stores Store { get; set; }
        public virtual ICollection<ProductOrders> ProductOrders { get; set; }
    }
}
