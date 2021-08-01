using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Desc = "Amasya elması";

            Product product2 = new Product();

            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Desc = "Diyarbakır karpuzu";

            Product[] products = new Product[]
            {
                product1,
                product2
            };

            foreach (Product product in products)
            {
                Console.WriteLine("İsim: " + product.Name + " - Açıklama: " + product.Desc + " - Fiyat: " + product.Price);
            }

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);

            basketManager.Add2("Armut", "Yeşil Armut", 21);
        }
    }
}
