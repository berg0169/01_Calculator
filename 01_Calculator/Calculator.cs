using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return (v1 + v2);
        }

        internal static int Subtract(int v1, int v2)
        {
            return (v1 - v2);
        }

        internal static int Sum(int[] numbers)
        {
            int k = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                k = k + numbers[i];
            }
            return k;
        }

        internal static int Multiply(int v1, int v2)
        {
            return (v1 * v2);
        }

        internal static int Power(int v1, int v2)
        {
            int k = 1;
            for (int i = 0;i < v2; i++)
            {
                k = k * v1;
            }
            return k;
        }
        internal static double Factorial(double v1)
        {
  
            {
              
                double k = 1;
                for (double i = v1; i > 0; i--)
                {
                    k = i * k;
                }
                return k;
            }
        }
    }
}