using System;
using System.Collections.Generic;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class Products
    {
        public Products()
        {
            ProductOrders = new HashSet<ProductOrders>();
            StoreProducts = new HashSet<StoreProducts>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public int? StoreId { get; set; }

        public virtual ICollection<ProductOrders> ProductOrders { get; set; }
        public virtual ICollection<StoreProducts> StoreProducts { get; set; }
    }
}
