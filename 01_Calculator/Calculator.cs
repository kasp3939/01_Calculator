using System;
using System.Linq;

namespace _01_Calculator
{
    public class Calculator
    {
     

        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
          
        {
            return numbers.Sum();
        }

        internal static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        internal static double Power(double v1, double v2)
        {
            return Math.Pow(v1, v2);
        }

      

        internal static long Factorial(long v)
        {
            long sum = 1;
            for (long i = v; i > 0; i--)
            {
                sum *= i;
            }
            return sum;
        }

        internal static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }
    }
}