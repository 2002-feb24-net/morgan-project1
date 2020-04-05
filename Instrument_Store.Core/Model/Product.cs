using System;
using System.ComponentModel.DataAnnotations;

namespace Instrument_Store.Core
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
       
        [Required]
        public string Name { get; set; }


        public string Type { get; set; }

        public string Brand { get; set; }

        [Required]
        public decimal? Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }

        public int? StoreId { get; set; }
        
    }
}
