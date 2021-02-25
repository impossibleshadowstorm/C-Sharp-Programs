using System;

namespace CountLowercaseNUppercase
{
    class CountLowercaseNUppercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n                   PROGRAM TO COUNT THE TOTAL NUMBER OF UPPERCASE AND LOWERCASE CHARACTER IN STRING");
            Console.WriteLine("                **----------------------------------------------------------------------------------**");

            Console.Write("\n\n\tENTER A STRING:: ");
            string sentence = Console.ReadLine();

            int len = sentence.Length, count_lower = 0, count_upper = 0;
            for (int i = 0; i < len; i++)
            {
                if (sentence[i] >= 65 && sentence[i] <= 90)
                    count_upper++;
                if (sentence[i] >= 97 && sentence[i] <= 122)
                    count_lower++;
            }

            Console.WriteLine("\n\n===============================================***********************=================================================");
            Console.WriteLine("                                               +++ UPPERCASE COUNT +++");
            Console.WriteLine("                                                 +++ =============== +++");
            Console.WriteLine("\n\tTOTAL NUMBER OF UPPERCASE LETTERS IN YOUR STRING IS:: {0}\n\n", count_upper);

            Console.WriteLine("===============================================***********************=================================================");
            Console.WriteLine("                                               +++ LOWERCASE COUNT +++");
            Console.WriteLine("                                               +++ =============== +++");
            Console.WriteLine("\n\tTOTAL NUMBER OF UPPERCASE LETTERS IN YOUR STRING IS:: {0}\n\n", count_lower);

            Console.ReadLine();
        }
    }
}
