using System;

namespace CheckAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("check the input alphabet is vowel or not");

            Console.WriteLine("\n\nInput an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("\n\nYou entered number,Enter an alphabet\n");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The alphabet is vowel");
                        break;









                }

            
            }
            Console.ReadKey();
        }
    }
}
