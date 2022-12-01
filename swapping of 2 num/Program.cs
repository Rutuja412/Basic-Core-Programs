using System;

namespace swapping_of_2_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter first number :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter second number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter swapping :");
            Console.Write("\nFirst number :" + num1);
            Console.Write("\nSecond number :" + num2);
            Console.Read();
        }
    }
}
