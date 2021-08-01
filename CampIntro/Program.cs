using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int uyeler = 351651;
            double faizOrani = 32132.1;
            bool girisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar düştü");
            }
            else if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Dolar arttı");
            }
            else
            {
                Console.WriteLine("Dolar aynı");
            }

            if (girisYapmisMi)
            {
                Console.WriteLine("Kullanıcı ayarı butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
