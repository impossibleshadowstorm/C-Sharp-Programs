using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rev =0;

            Console.Write("ENTER THE NUMBER:: ");
            num = Convert.ToInt32( Console.ReadLine());
            int temp = num;

            while (num > 0)
            {
                rev = rev * 10 + (num % 10);
                num /= 10;
            }
            Console.WriteLine("REVERSE OF {0} NUMBER IS:: {1}", temp, rev);

            Console.ReadLine();

        }
    }
}
