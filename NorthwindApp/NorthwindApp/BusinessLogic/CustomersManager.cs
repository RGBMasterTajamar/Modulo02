using NorthwindApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NorthwindApp.BusinessLogic
{
    public class CustomersManager
    {
        string connectionQuery = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
        private NorthwindDataContext _context;

        public CustomersManager()
        {
            _context = new NorthwindDataContext(connectionQuery);
        }

        public List<Customers> GetCustomers() 
        {
            return _context.Customers.ToList();
        }

        public Customers GetCustomerByID(string customerId)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerID == customerId);
        }

        public List<Orders> GetOrdersByCustomerId(string customerId)
        {
            return _context.Orders.Where(o=>o.CustomerID == customerId).ToList();
        }
    }
}