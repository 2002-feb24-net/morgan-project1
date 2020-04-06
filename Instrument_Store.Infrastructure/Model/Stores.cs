using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class Stores
    {
        public Stores()
        {
            Customers = new HashSet<Customers>();
            Orders = new HashSet<Order>();
        }

        public int StoreId { get; set; }

        [Required(ErrorMessage = "A city is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "A state is required")]
        public string State { get; set; }

        public virtual StoreProducts StoreProducts { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
