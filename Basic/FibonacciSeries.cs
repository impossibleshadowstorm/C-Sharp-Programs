using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, next, no_of_terms;

            Console.WriteLine("                               PROGRAM TO PRINT FIBONACCI SERIES");
            Console.WriteLine("                            **-----------------------------------**");

            Console.Write("\n\nENTER THE NO OF TERMS IN SERIES:: ");
            no_of_terms = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\n=========================================================================================================");
            if (no_of_terms >= 1)
            {
                Console.WriteLine("                                                 +++ SERIES +++");
                Console.WriteLine("                                                 +++ ====== +++");
            }

            if(no_of_terms > 2)
            {
                Console.Write("\n\n{0} {1} ", num1, num2);

                for (int i = 2; i <= no_of_terms;i++)
                {
                    next = num1 + num2;
                    Console.Write("{0} ", next);

                    num1 = num2;
                    num2 = next;
                }
            }
            else if(no_of_terms == 1)
            {
                Console.Write("{0} ", num1);
            }
            else if(no_of_terms == 2)
            {
                Console.Write("{0} {1} ", num1, num2);
            }
            else
            {
                Console.WriteLine("\n\n\n\tERROR !!! \n\tINVALID INPUT VALUE!! \n\tPLEASE INPUT POSITIVE INTEGER VALUE GREATER THAN 1!!");
            }

            Console.WriteLine("\n\n\n=========================================================================================================");

            Console.ReadLine();
        }
    }
}
