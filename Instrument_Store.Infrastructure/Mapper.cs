using System;
using System.Collections.Generic;
using System.Text;

namespace Instrument_Store.Infrastructure
{
    public static class Mapper
    {
        public static Core.Customer MapCustomer(Model.Customers customers )
        {
            return new Core.Customer
            {
                CustomerId = customers.CustomerId,
                LastName = customers.LastName,
                FirstName = customers.FirstName,
                StoreId = customers.StoreId,
                Phone = customers.Phone,
                Address = customers.Address,
                City = customers.City,
                State = customers.State,
                FullName = customers.FullName
            };
        }

        public static Model.Customers MapCustomer(Core.Customer customers)
        {
            return new Model.Customers
            {
                CustomerId = customers.CustomerId,
                LastName = customers.LastName,
                FirstName = customers.FirstName,
                StoreId = customers.StoreId,
                Phone = customers.Phone,
                Address = customers.Address,
                City = customers.City,
                State = customers.State,
                FullName = customers.FullName
            };
        }

        public static Core.Order MapOrder(Model.Orders orders)
        {
            return new Core.Order
            {
                OrderId = orders.OrderId,
                CustomerId = orders.CustomerId,
                ProductOrdersId = orders.ProductOrdersId,
                StoreId = orders.StoreId,
                Date = orders.Date,
                Quantities = orders.Quantities,
                TotalPrice = orders.TotalPrice
            };
        }

        public static Model.Orders MapOrder(Core.Order orders)
        {
            return new Model.Orders
            {
                OrderId = orders.OrderId,
                CustomerId = orders.CustomerId,
                ProductOrdersId = orders.ProductOrdersId,
                StoreId = orders.StoreId,
                Date = orders.Date,
                Quantities = orders.Quantities,
                TotalPrice = orders.TotalPrice
            };
        }

        public static Model.Products MapProduct(Model.Products products)
        {
            return new Model.Products
            {
                ProductId = products.ProductId,
                Name = products.Name,
                Type = products.Type,
                Brand = products.Brand,
                Price = products.Price,
                Quantity = products.Quantity,
                StoreId = products.StoreId
            };
        }

        public static Core.Product MapProduct(Core.Product products)
        {
            return new Core.Product
            {
                ProductId = products.ProductId,
                Name = products.Name,
                Type = products.Type,
                Brand = products.Brand,
                Price = products.Price,
                Quantity = products.Quantity,
                StoreId = products.StoreId
            };
        }

        public static Model.ProductOrders MapProductOrder(Model.ProductOrders productOrder)
        {
            return new Model.ProductOrders
            {
                ProductOrderId = productOrder.ProductOrderId,
                ProductId = productOrder.ProductId,
                OrderId = productOrder.OrderId,
                Quantity = productOrder.Quantity
            };
        }

        public static Core.ProductOrder MapProductOrder(Core.ProductOrder productOrder)
        {
            return new Core.ProductOrder
            {
                ProductOrderId = productOrder.ProductOrderId,
                ProductId = productOrder.ProductId,
                OrderId = productOrder.OrderId,
                Quantity = productOrder.Quantity
            };
        }

        public static Core.Store MapStore(Core.Store store)
        {
            return new Core.Store
            {
                StoreId = store.StoreId,
                City = store.City,
                State = store.State
            };
        }

        public static Model.Stores MapStore(Model.Stores store)
        {
            return new Model.Stores
            {
                StoreId = store.StoreId,
                City = store.City,
                State = store.State
            };
        }
    }
}
