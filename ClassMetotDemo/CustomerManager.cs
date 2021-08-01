using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer> { };
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Müşteri başarıyla eklendi: " + customer.FirstName + " " + customer.LastName);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Müşteri başarıyla silindi." + customer.FirstName + " " + customer.LastName);
        }

        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id: " + customer.Id);
                Console.WriteLine("İsim: " + customer.FirstName);
                Console.WriteLine("Soyisim: " + customer.LastName);
                Console.WriteLine("********");
            }

        }
    }
}
