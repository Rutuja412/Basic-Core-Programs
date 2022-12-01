﻿using System;

namespace HarmonicNumProgram
{
    internal class Program
    {
        static double nthHarmonic(int N)
        {

            float harmonic = 1;

            for (int i = 2; i < N; i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;

        }
        static void Main()
        {
            int N = 20;
            Console.WriteLine(nthHarmonic(N));
        }
    }
}
