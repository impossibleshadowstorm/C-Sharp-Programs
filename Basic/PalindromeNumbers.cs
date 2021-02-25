using System;

namespace PalindromeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, rev =0;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                         PROGRAM TO CHECK PALINDROME");
            Console.WriteLine("                     **-------------------------------**");

            Console.Write("ENTER THE NUMBER TO CHECK:: ");
            number = Convert.ToInt32(Console.ReadLine());
            int temp = number;

            Console.WriteLine("");
            Console.WriteLine("");

            while(number > 0)
            {
                rev = rev * 10 + (number % 10);
                number /= 10;
            }

            if(temp == rev)
            {
                Console.WriteLine("{0} IS A PALINDROME NUMBER !!", temp);
            }
            else
            {
                Console.WriteLine("{0} IS NOT A PALINDROME NUMBER !!", temp);
            }

            Console.ReadLine();
        }
    }
}
