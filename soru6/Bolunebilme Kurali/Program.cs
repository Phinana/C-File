using System;

namespace Bolunebilme_Kurali
{
    class Program
    {
        static void Main(string[] args)
        {
            int b2t = 0, b2k = 0, 
                b3t = 0, b3k = 0, 
                b4t = 0, b4k = 0, 
                b5t = 0, b5k = 0, 
                b6t = 0, b6k = 0, 
                b7t = 0, b7k = 0, 
                b8t = 0, b8k = 0, 
                b9t = 0, b9k = 0,  
                odd = 0, even = 0,
                tfset = 0, tfsek = 0, 
                tst = 0, tsk = 0;
               

            for(int number = 1; number <= 300; number++)
            {
                if(number % 2 == 0)
                {
                    b2t = b2t + number;
                    b2k++;
                    odd++;
                }else if(number % 2 != 0)
                {
                    even++;
                }

                if (number % 3 == 0)
                {
                    b3t = b3t + number;
                    b3k++;
                }

                if (number % 4 == 0)
                {
                    b4t = b4t + number;
                    b4k++;
                }

                if (number % 5 == 0)
                {
                    b5t = b5t + number;
                    b5k++;
                }

                if (number % 6 == 0)
                {
                    b6t = b6t + number;
                    b6k++;
                }

                if (number % 7 == 0)
                {
                    b7t = b7t + number;
                    b7k++;
                }

                if (number % 8 == 0)
                {
                    b8t = b8t + number;
                    b8k++;
                }

                if (number % 9 == 0)
                {
                    b9t = b9t + number;
                    b9k++;
                }

                if(number % 2 == 0 && number % 4 == 0 && number % 6 == 0 && number % 8 == 0)
                {
                    tfset = tfset + number;
                    tfsek++;
                }

                if(number % 3 == 0 && number % 7 == 0)
                {
                    tst = tst + number;
                    tsk++;
                }
            }
            Console.WriteLine("2 ile bolunebilen " + b2k + " sayinin toplami " + b2t + " yapar.");
            Console.WriteLine("3 ile bolunebilen " + b3k + " sayinin toplami " + b3t + " yapar.");
            Console.WriteLine("4 ile bolunebilen " + b4k + " sayinin toplami " + b4t + " yapar.");
            Console.WriteLine("5 ile bolunebilen " + b5k + " sayinin toplami " + b5t + " yapar.");
            Console.WriteLine("6 ile bolunebilen " + b6k + " sayinin toplami " + b6t + " yapar.");
            Console.WriteLine("7 ile bolunebilen " + b7k + " sayinin toplami " + b7t + " yapar.");
            Console.WriteLine("8 ile bolunebilen " + b8k + " sayinin toplami " + b8t + " yapar.");
            Console.WriteLine("9 ile bolunebilen " + b9k + " sayinin toplami " + b9t + " yapar.");
            Console.WriteLine(odd + " adet cift sayi ve " + even + " adet tek sayi bulunmustur.");
            Console.WriteLine("2-4-6-8 sayilarina ayni anda tam bolunebilen " + tfsek + " sayinin toplami " + tfset + " yapar.");
            Console.WriteLine("3-7 sayilarina ayni anda tam bolunebilen " + tsk + " sayinin toplami " + tst + " yapar.");
        }
    }
}
