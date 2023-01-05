using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDuos
{
    internal class IntegerDuos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Integer Duos---");
            int[] numbers = menu();
            int[] result = integerDuosCalc(numbers);
            Console.Write("Sonuc: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
                

        }

        static int[] menu()
        {
                Console.Write("İkili tam sayılar arasında işlem yapmak üzere kullanılacak sayılar listesinin boyutunu giriniz: ");
                int length = Convert.ToInt32(Console.ReadLine());
                if(length % 2 != 0)
                {
                    Console.WriteLine("Lütfen liste boyutuna çift bir sayı giriniz!");
                }
            
            
            int counter = 0;
            int[] numbers = new int[length];

            Console.Write(length + " adet sayı giriniz: ");
            while (counter < length)
            {
                for (int i = 0; i < length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    counter++;
                }
            }
            return numbers;
        }

        static int[] integerDuosCalc(int[] numbers)
        {
            int length = numbers.Length;
            int[] resultList = new int[length / 2];

            for(int i = length - 1; i > 0; i=i-2)
            {
                for(int j = resultList.Length - 1; j >= 0; j--)
                {
                    if (resultList[j] == 0)
                    {
                        if (numbers[i] == numbers[i - 1])
                        {
                            resultList[j] = (int)Math.Pow((2 * numbers[i]), 2);
                            break;
                        }
                        else
                        {
                            resultList[j] = numbers[i] + numbers[i - 1];
                            break;
                        }
                    }
                }
            }
            return resultList;
        }       

    }
}
