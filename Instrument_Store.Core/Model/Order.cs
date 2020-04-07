using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Instrument_Store.Core
{
    public class Order
    {

        [Required]
        public int OrderId { get; set; }
        
        [Required]
        public int CustomerId { get; set; }
        
        [Required]
        public int ProductOrdersId { get; set; }
        
        [Required]
        public int StoreId { get; set; }

        public DateTime? Date { get; set; }

        public int? Quantities { get; set; }

        public List<Product> products { get; set; } = new List<Product>();

        public decimal? TotalPrice { get; set; }
    }
}
