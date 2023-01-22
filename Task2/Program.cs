﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetName = "numbers.txt";
            Random random= new Random();
            using(StreamWriter sw = new StreamWriter(targetName))
            {
                for (int i = 0; i < 10; i++)
                    sw.WriteLine(random.Next(-10,10));
            }
            int sum = 0; 
            using (StreamReader sr = new StreamReader(targetName))
            {
                for (int i = 0; i < 10; i++)
                    sum += Convert.ToInt32(sr.ReadLine());
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
