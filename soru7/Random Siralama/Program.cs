using System;
using System.Collections.Generic;

namespace Random_Siralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int temp = 0;
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(301);
            }

            Array.Sort(array);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(array[i]);
                temp = temp + array[i];
            }

            temp = temp / 20;
            Console.WriteLine("En kucuk sayi " + array[0]);
            Console.WriteLine("En buyuk sayi " + array[19]);
            Console.WriteLine("Aritmetik ortalama " + temp);
        }
    }
}
