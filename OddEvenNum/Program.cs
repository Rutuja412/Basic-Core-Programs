using System;

namespace OddEvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number :");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered number is Even number");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Entered number is Odd number ");
                Console.Read();
            }
        
        }
    }
}
