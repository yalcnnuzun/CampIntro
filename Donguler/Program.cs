using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "Yazılım geliştirme kampı",
                "Proglamlamaya giriş kursu",
                "Java",
                "C#"

            };

            /*for (int i = 0; i <= kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }*/

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
