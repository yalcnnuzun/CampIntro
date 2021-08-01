using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class BasketManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi: "+ product.Name);
        }

        public void Add2(string productName, string desc, double price)
        {
            Console.WriteLine("Tebrikler eklendi: " + productName);
        }
    }
}
