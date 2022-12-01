using System;

namespace Largest_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int large;
            Console.WriteLine("Enter 1st num:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("/n/nEnter 2nd num:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("/n/nEnter 3 rd num:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;

            Console.WriteLine("Largest number {0}",large);
        }
    }
}
