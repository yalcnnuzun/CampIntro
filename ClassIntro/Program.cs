using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "yalçın";
            int yas = 17;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            //Console.WriteLine("Kurs Adı: "+kurs1.KursAdi + " | Kurs Eğitmeni: " + kurs1.Egitmen + " | İzleme Oranı: "+ kurs1.IzlenmeOrani);


            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 97;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            


            Kurs[] kurslar =
            {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
