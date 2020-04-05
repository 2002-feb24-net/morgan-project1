using Instrument_Store.Core;
using Instrument_Store.Infrastructure.Interfaces;
using Instrument_Store.Infrastructure.Model;
using NLog;
using System;

namespace Instrument_Store.Infrastructure.Repositories
{
    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly StoreDbContext _cont;

        private static readonly ILogger s_logger = LogManager.GetCurrentClassLogger();
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void CustomerOrderHistory(Order order)
        {
            throw new NotImplementedException();
        }

        public void EditCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void LoginCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void StoreOrderHistory(Order order)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            s_logger.Info("Saving changes to the database");
            _cont.SaveChanges();
        }
    }
}
