using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Instrument_Store.Core
{
    public class StoreProduct
    {
        public int ProductId { get; set; }

        public int StoreId { get; set; }

        public int Quantity { get; set; }

        [Required]
        public int StoreProductsId { get; set; }
    }
}
