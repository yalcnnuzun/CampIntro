using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Yalçın";
            customer1.LastName = "Uzun";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Kemalcan";
            customer3.LastName = "Parlak";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Dora";
            customer4.LastName = "Özsoy";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            Console.WriteLine("------------ Müşteriler Eklendi ------------");
            Console.WriteLine(" ");

            customerManager.List();
            Console.WriteLine("----------- Müşteriler Listlendi -----------");
            Console.WriteLine(" ");


            customerManager.Remove(customer3);
            customerManager.Remove(customer1);
            Console.WriteLine("------------ Müşteriler Silindi ------------");
            Console.WriteLine(" ");


            customerManager.List();
            Console.WriteLine("----------- Müşteriler Listlendi -----------");
            Console.WriteLine(" ");
        }
    }
}
