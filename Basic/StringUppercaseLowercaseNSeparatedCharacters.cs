using System;

namespace StringSeparatedCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                      PROGRAM TO UPPERCASE, LOWERCASE & SEPARATE THE CHARACTERS FROM STRINGS");
            Console.WriteLine("                   **-------------------------------------------------------------------------**");
            
            
            Console.Write("\n \n ENTER A STRING:: ");
            string orig_string = Console.ReadLine();

            int len = orig_string.Length;

            Console.WriteLine("\n                                               UPPERCASE");
            Console.WriteLine("                                             **------------**\n");
            Console.WriteLine("{0} IN UPPPERCASE IS:: {1}", orig_string, orig_string.ToUpper());


            Console.WriteLine("\n                                              LOWERCASE");
            Console.WriteLine("                                             **------------**\n");
            Console.WriteLine("{0} IN UPPPERCASE IS:: {1}", orig_string, orig_string.ToLower());


            Console.WriteLine("\n                                      SPACE SEPARATED CHARACTERS");
            Console.WriteLine("                                    **-----------------------------**\n");
            Console.Write("\n \n SPACE SEPARATED CHARACTERS IN STRINGS ARE:: ");
            for(int i = 0; i < len; i++)
            {
                Console.Write("{0} ", char.ToUpper(orig_string[i]));
            }

            Console.ReadLine();
        }
    }
}
