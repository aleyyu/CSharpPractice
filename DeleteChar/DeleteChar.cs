using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteChar
{
    internal class DeleteChar
    {
        static void Main(string[] args)
        {
            Console.Write("Arasında virgülle bir text ve bir index giriniz: ");
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(", ");
            string text = splittedInput[0];
            int index = Convert.ToInt32(splittedInput[1]);
            Console.WriteLine(deleteChar(text, index));

        }

        static string deleteChar(string text, int index)
        { 
            return text.Remove(index, 1);
        }
    }
}
