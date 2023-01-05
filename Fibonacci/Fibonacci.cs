using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int depth = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(fibonacciCalculator(depth));
            int[] fibo = fibonacciCalculator(depth);
            Console.Write("Fibonacci serisinin sayılarının ortalaması: " + fibonacciAverageCalc(fibo));

        }

        static int[] fibonacciCalculator(int depth)
        {
            int[] fibonacci = new int[depth];
            int sum = 0;
            double average = 0;

            for (int i = 0; i < depth; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacci[i] = 1;
                }
                else
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                sum += fibonacci[i];
            }
            return fibonacci;
        }

        static double fibonacciAverageCalc(int[] fibonacci)
        {
            int sum = 0;
            double average = 0;
            int depth = fibonacci.Length;

            for (int i = 0; i < depth; i++)
            {
                sum += fibonacci[i];
            }
            average = (double)sum / depth;
            return average;
        }
    }
}
