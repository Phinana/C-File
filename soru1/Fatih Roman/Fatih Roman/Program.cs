using System;

namespace Fatih_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 24, book = 564, result = 0, current = 0;

            while (current < book)
            {
                current = current + temp;
                temp = temp + 8;
                result++;
            }

            Console.WriteLine(result + " Gunde okunmustur.");
        }
    }
}
