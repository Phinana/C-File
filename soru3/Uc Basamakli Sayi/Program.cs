using System;

namespace Uc_Basamakli_Sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1, b2, b3, temp, result = 0;

            Console.WriteLine("3 basamakli olan ve basamaklarinda bulunan rakamlar birbirinden farkli olan sayilar hesaplaniyor.");

            for(int i = 100; i < 1000; i++)
            {
                temp = i;
                b3 = temp / 100;
                temp = temp - (b3 * 100);
                b2 = temp / 10;
                temp = temp - (b2 * 10);
                b1 = temp;

                if(b1 != b2 && b1 != b3 && b2 != b3)
                {
                    result++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(result + " tane sayı vardir.");
        }
    }
}
