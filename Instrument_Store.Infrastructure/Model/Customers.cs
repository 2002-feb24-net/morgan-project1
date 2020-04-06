using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instrument_Store.Infrastructure.Model
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "A last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A first name is required")]
        public string FirstName { get; set; }

        public int StoreId { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone number (10 digits)")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string FullName { get; set; }

        public virtual Stores Store { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
