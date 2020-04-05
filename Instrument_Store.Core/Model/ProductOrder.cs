using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Instrument_Store.Core
{
    public class ProductOrder
    {
        [Required]
        public int ProductOrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public int OrderId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
