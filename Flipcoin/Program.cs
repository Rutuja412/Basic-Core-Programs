using System;
using System.Data;

namespace Flipcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter number to flip coin");
            n = int.Parse(Console.ReadLine());
            int CountHead = 0;
            int CountTail = 0;

            for(i=1;i<=n;i++)
            {
                Random random= new Random();
                int num=random.Next(3);

                if (num==1)
                {
                    Console.WriteLine("Heads");
                    CountHead++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    CountTail++;
                }
            }
            Console.WriteLine("number of Heads : {0}", CountHead);
            Console.WriteLine("number of Tails  :{0}", CountTail);

            double Heads = CountHead / (double)n * 100;
            double Tails = CountTail / (double)n * 100;

            Console.WriteLine(" percentage of heads  :{0}", Heads);
            Console.WriteLine(" percentage of tails   :{0}", Tails);


        }
    }
}
