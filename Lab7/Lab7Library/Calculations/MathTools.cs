using Lab7Library.Common;
using System;

namespace Lab7Library.Calculations
{
    public static class MathTools
    {
        public static double CalculateAverage(double first, double second, double third)
        {
            if(!ValidationTools.IsPositive(first))
                Console.WriteLine($"{first} lesser than 0");
            if (!ValidationTools.IsPositive(second))
                Console.WriteLine($"{second} lesser than 0");
            if (!ValidationTools.IsPositive(third))
                Console.WriteLine($"{third} lesser than 0");
            return (first + second + third) / 3.0f;
        }
    }
}