using System;

namespace FizzBuzzProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int count3 = 0, count5 = 0;
            string print = "";

            Console.WriteLine("                                          PROGRAM TO SOLVE FIZBUZZ PROBLEM");
            Console.WriteLine("                                       **----------------------------------**");

            Console.WriteLine("                                      +++ METHOD 1 [Using Modulus Operator] +++");
            Console.WriteLine("                                      +++ ================================= +++");

            for(int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("\t\t\t\t\t\t\tFizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("\t\t\t\t\t\t\tFizz");
                else if (i % 5 == 0)
                    Console.WriteLine("\t\t\t\t\t\t\tBuzz");
                else
                    Console.WriteLine("\t\t\t\t\t\t\t" + i);
            }
            
            
            Console.WriteLine("\n\n                                  +++ METHOD 2 [Without Using Modulus Operator] +++");
            Console.WriteLine("                                  +++ ========================================= +++");

            for (int i = 1; i<= 15; i++)
            {
                count3++;
                count5++;

                if(count3 == 3)
                {
                    print += "Fizz";
                    count3 = 0;
                }
                if(count5 == 5)
                {
                    print += "Buzz";
                    count5 = 0;
                }

                if(print == "")
                {
                    Console.WriteLine("\t\t\t\t\t\t\t" + i);
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\t\t\t" +print);
                    print = "";
                }
            }

            Console.ReadLine();

        }
    }
}
