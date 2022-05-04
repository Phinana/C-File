using System;

namespace Mukemmel_Sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp, result = 0;

            Console.WriteLine("Sayiyi giriniz.");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    result = result + i;
                }
            }
     
            if (result == number)
            {
                Console.WriteLine("Girdıginiz sayi mukemmel bir sayidir.");
            }
            else
            {
                Console.WriteLine("Uzgunum, bu sayi mukemmel bir sayi degildir.");
            }
        }
    }
}
