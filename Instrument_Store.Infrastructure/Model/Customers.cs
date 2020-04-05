﻿using System;
using System.Collections.Generic;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int StoreId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FullName { get; set; }

        public virtual Stores Store { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
