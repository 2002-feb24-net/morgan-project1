using Instrument_Store.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instrument_Store.Infrastructure.Interfaces
{
    public interface IInstrumentRepository
    {

        void LoginCustomer(Customer customer);

        void AddCustomer(Customer customer);

        void EditCustomer(Customer customer);

        void SearchCustomer(Customer customer);

        void CustomerOrderHistory(Order order);

        void CreateOrder(Order order);

        void StoreOrderHistory(Order order);
    }
}
