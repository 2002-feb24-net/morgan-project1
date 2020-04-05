using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Instrument_Store.Core.Model
{
    class StoreProduct
    {
        public int ProductId { get; set; }

        public int StoreId { get; set; }

        public int Quantity { get; set; }

        public int StoreProductsId { get; set; }
    }
}
