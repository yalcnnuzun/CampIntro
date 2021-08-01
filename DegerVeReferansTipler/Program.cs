using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            Console.WriteLine(number1);

            int[] numbers = new int[]
            {
                10,
                20,
                30
            };

            int[] numbers2 = new int[]
            {
                100,
                200,
                300
            };

            numbers = numbers2;

            numbers2[0] = 999;

            Console.WriteLine(numbers[0]);

            string word = "kelime";
            string word2 = "kelime2";
            word = word2;

            word2 = "kelime3";
            Console.WriteLine(word);







        }
    }
}
