using System;

namespace En_Buyuk_Hane
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp = 0, digit = 0, result = 0;
            Console.WriteLine("Sayiyi Giriniz");
            number = Convert.ToInt32(Console.ReadLine());

            temp = number;
            while(number > 0)
            {
                number = number / 10;
                digit++;
            }

            number = temp;
            temp = 0;
            while (digit > 0)
            {
                temp = (int) ((number % Math.Pow(10, digit)) / Math.Pow(10, digit - 1));
                if(temp > result)
                {
                    result = temp;
                }
                digit--;
            }

            Console.WriteLine("En buyuk rakam = " + result);
        }
    }
}
