using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customers;
        public InMemoryCustomerDal()
        {
            _customers = new List<Customer>
            {
                new Customer {CustomerId=1, FirstName="Fatih", LastName="Dağ", TcNo="1234567890", birthYear=2004},
                new Customer {CustomerId=2, FirstName="Engin", LastName="Demiroğ", TcNo="1234567891", birthYear=2004},
                new Customer {CustomerId=3, FirstName="Mehmet", LastName="Nur", TcNo="1234567892", birthYear=2004},
                new Customer {CustomerId=4, FirstName="Ayşe", LastName="Dağ", TcNo="1234567893", birthYear=2004},
                new Customer {CustomerId=5, FirstName="Selman", LastName="Akdağ", TcNo="1234567894", birthYear=2004}
            };
        }
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            Customer customerToDelete;
            customerToDelete = _customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
            _customers.Remove(customerToDelete);
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void List()
        {
            foreach (var customer in _customers)
            {
                Console.WriteLine("Customer name:\t\t" + customer.FirstName);
                Console.WriteLine("Customer surname:\t" + customer.LastName);
                Console.WriteLine("Customer TC no:\t\t" + customer.TcNo);
                Console.WriteLine("Customer birth year:\t" + customer.birthYear);
                Console.WriteLine();
            }
        }

        public void Update(Customer customer)
        {
            Customer customerToDelete;
            customerToDelete = _customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);

            customerToDelete.FirstName = customer.FirstName;
            customerToDelete.LastName = customer.LastName;
            customerToDelete.TcNo = customer.TcNo;
            customerToDelete.birthYear = customer.birthYear;

        }
    }
}
