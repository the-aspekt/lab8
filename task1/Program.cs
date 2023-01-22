using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetDirectory = @"E:\Pavel\Документы\!C#\Speciments";
            string[] targetDirectoryCatalogue = Directory.GetDirectories(targetDirectory,"*",SearchOption.AllDirectories);
            foreach (string item in targetDirectoryCatalogue)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
