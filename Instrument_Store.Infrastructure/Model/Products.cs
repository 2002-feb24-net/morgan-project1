using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "A product name is required")]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }

        [Required(ErrorMessage = "A price is required")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "A quantity is required")]
        public int Quantity { get; set; }
        public int? StoreId { get; set; }

        public virtual ICollection<ProductOrders> ProductOrders { get; set; }
        public virtual ICollection<StoreProducts> StoreProducts { get; set; }
    }
}
