using System;

namespace PalindromeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string rev = "";

            Console.WriteLine("                                      PROGRAM TO CHECK PALINDROME STRINGS");
            Console.WriteLine("                                  **--------------------------------------**");

            Console.Write("ENTER A STRING:: ");
            string words = Console.ReadLine();

            Console.WriteLine("");

            //Store the length of string helpful in iterating through the strings indiviual letters
            int len = words.Length;

            if (len > 0)
            {
                for (int i = len - 1; i >= 0; i--)
                {
                    rev += words[i];
                }

                if (words == rev)
                    Console.WriteLine("{0} IS A PALINDROME STRING !!", words);
                else
                    Console.WriteLine("{0} IS NOT A PALINDROME STRING !!", words);
            }
            else
            {
                Console.WriteLine("SORRY, YOU HAVEN'T ENTERED ANY STRING !!");
            }
            Console.ReadLine();
        }
    }
}