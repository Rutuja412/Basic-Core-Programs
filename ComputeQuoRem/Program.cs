using System;

namespace ComputeQuoRem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, div, rem, quo = 0;
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Divisor :");
            div = Convert.ToInt32(Console.ReadLine());

            if (num > div)
            {
                while (num >= div)
                {
                    num = num - div;
                    quo++;
                }
                rem = num;
                Console.WriteLine("\nThe quotient is : " + quo + "\nThe remainder is :" + rem);
            }
            else
                Console.WriteLine("Enter valid input");
            Console.ReadLine();
        }
    }
}
