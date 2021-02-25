using System;

namespace GcdNLcm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n                                          PROGRAM TO FIND GCD AND LCM");
            Console.WriteLine("                                       **-----------------------------**");

            Console.Write("\n\n\tENTER FIRST NUMBER:: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tENTER SECOND NUMBER:: ");
            int second = Convert.ToInt32(Console.ReadLine());
            int gcd = 1;

            for(int i = 1; i <= first && i<= second; i++)
            {
                if (first % i == 0 && second % i == 0)
                {
                    gcd = i;
                }
            }

            Console.WriteLine("\n\n                                     +++ GREATEST COMMON DIVISOR [GCD] +++");
            Console.WriteLine("                                     +++ ----------------------------- +++");
            Console.WriteLine("\n\tGCD OF {0} AND {1} IS:: {2}", first, second, gcd);

            int lcm = (first * second) / gcd;

            Console.WriteLine("\n\n                                     +++ LEAST COMMON MULTIPLE [LCM] +++");
            Console.WriteLine("                                     +++ --------------------------- +++");
            Console.WriteLine("\n\tGCD OF {0} AND {1} IS:: {2}", first, second, lcm);
            
            Console.ReadLine();
        }
    }
}
