using Instrument_Store.Core;
using Instrument_Store.Infrastructure.Interfaces;
using Instrument_Store.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Instrument_Store.Infrastructure.Repositories
{
    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly StoreDbContext _cont = new StoreDbContext();

        private static readonly ILogger s_logger = LogManager.GetCurrentClassLogger();

        public IEnumerable<Core.Customer> GetCustomers(string search = null)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Customers> items = _cont.Customers.Include(s => s.Store);
            if (search != null)
            {
                items = items.Where(r => r.FullName.Contains(search));
            }
            return items.Select(Mapper.MapCustomer);
        }

        public IEnumerable<Core.Store> GetStores(string search = null)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Stores> items = _cont.Stores;
            if (search != null)
            {
                items = items.Where(s => s.State.Contains(search));
            }
            return items.Select(Mapper.MapStore);
        }
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
