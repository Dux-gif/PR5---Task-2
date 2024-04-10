using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5___Task_2
{
    internal class Program
    {
        static string ReversWords(string text)
        {
            string[] wordsSplit = text.Split(' ');
            string newText = Reverse(wordsSplit);
            return newText;
        }
        static string Reverse(string[] text) 
        {
            Array.Reverse(text);
            string s = string.Join(" ", text);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine("Введите предложение: ");

            string test = Console.ReadLine();

            test = ReversWords(test);


            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
