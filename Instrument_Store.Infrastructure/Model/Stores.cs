using System;
using System.Collections.Generic;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class Stores
    {
        public Stores()
        {
            Customers = new HashSet<Customers>();
            Orders = new HashSet<Orders>();
        }

        public int StoreId { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual StoreProducts StoreProducts { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
