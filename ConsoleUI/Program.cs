using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new InMemoryCustomerDal());
            

            while (true)
            {
                Console.WriteLine("Press 1 to add member");
                Console.WriteLine("Press 2 to delete member");
                Console.WriteLine("Press 3 to update member");
                Console.WriteLine("Press 4 to list all members");

                var key = Console.ReadKey().KeyChar;
                Console.Clear();

                if (key == '1')
                {
                    Customer customer = new Customer();

                    Console.Write("Name of new member: ");
                    customer.FirstName = Console.ReadLine();

                    Console.Write("Surname of new member: ");
                    customer.LastName = Console.ReadLine();

                    Console.Write("TC no of new member: ");
                    customer.TcNo = Console.ReadLine();

                    Console.WriteLine("Birth year of new member: ");
                    customer.birthYear = Convert.ToInt32(Console.ReadLine());

                    customerManager.Add(customer);
                }
                if (key == '2')
                {
                    Console.WriteLine("Enter ID you want to delete: ");
                    var key2 = Console.ReadKey().KeyChar;

                    Customer customer2 = new Customer
                    {
                        CustomerId = int.Parse(key2.ToString())
                    };
                    Console.WriteLine(int.Parse(key2.ToString()));

                    customerManager.Delete(customer2);
                }
                if (key == '3')
                {
                    Customer customer = new Customer();

                    Console.Write("New name of member: ");
                    customer.FirstName = Console.ReadLine();

                    Console.Write("New surname of member: ");
                    customer.LastName = Console.ReadLine();

                    Console.Write("New TC no of member: ");
                    customer.TcNo = Console.ReadLine();

                    Console.WriteLine("New Birth year of member: ");
                    customer.birthYear = Convert.ToInt32(Console.ReadLine());
                    customer.CustomerId = 5;
                    customerManager.Update(customer);
                }
                if (key == '4')
                {
                    customerManager.List();
                }
            }

        }
    }
}
