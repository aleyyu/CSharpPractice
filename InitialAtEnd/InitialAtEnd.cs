using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialAtEnd
{
    internal class InitialAtEnd
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime giriniz: ");
            string text = Console.ReadLine();
            Console.WriteLine(putInitialAtEnd(text));
        }

        static string putInitialAtEnd(string text)
        {
            int length = text.Length;
            string newText = text.Substring(1) + text[0];
            return newText;
        }
    }
}
