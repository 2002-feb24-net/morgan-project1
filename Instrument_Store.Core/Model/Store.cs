using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Instrument_Store.Core
{
    public class Store
    {
        [Required]
        public int StoreId { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
