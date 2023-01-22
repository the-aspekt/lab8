using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetName = "Essay.txt";
            int symbolsNumber=0, stringsNumber = 0, wordsNumber=0;
            using(StreamReader sr = new StreamReader(targetName))
            {
                string text = sr.ReadToEnd();
                symbolsNumber = text.Length;
                string[] textArray = text.Split(' ');
                wordsNumber = textArray.Length;
            }
            using (StreamReader sr = new StreamReader(targetName))
            {
                string currentLine = "text";
                while (currentLine != null)
                {
                    currentLine = sr.ReadLine();
                    stringsNumber++;
                }
            }
            Console.WriteLine("Количество символов в тексте {3} составляет {0}, количество слов {1}, количество строк {2}", symbolsNumber,  wordsNumber, stringsNumber, targetName);
            Console.ReadKey();
        }
    }
}
