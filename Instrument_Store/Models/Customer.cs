using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Instrument_Store.Web.Models
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }


        public string LastName { get; set; }


        public string FirstName { get; set; }


        [Required]
        public int StoreId { get; set; }

        [Required]
        public string Email { get; set; }


        public string Phone { get; set; }


        public string Address { get; set; }


        public string City { get; set; }


        public string State { get; set; }


        public string FullName { get; set; }
    }
}
