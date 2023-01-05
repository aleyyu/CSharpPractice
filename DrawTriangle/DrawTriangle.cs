using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    internal class DrawTriangle
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size of triangle: ");
            size = Convert.ToInt32(Console.ReadLine());
            drawTriangle(size);
        }

        /*
         
        size = 7
         
        i           yıldız (i+1)    boşluk
        0-------*          1          7
        1------* *         2          6
        2-----* * *        3          5
        3----* * * *       4          4
        4---* * * * *      5          3
        5--* * * * * *     6          2
        6-* * * * * * *    7          1
        7* * * * * * * *   8          0

        size = 3 
        i          (i+1)    
        0   *       1       3
        1  * *      2       2
        2 * * *     3       1
        3* * * *    4       0
         */

        static void drawTriangle(int size)
        {
            int bosluk = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }
                bosluk--;
                for (int j = 0; j < (i + 1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /*
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            */
        }
    }
}
