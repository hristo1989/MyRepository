﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Place enter a number:");

            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine();
            Console.Write("Celochisleno delene na 3:    ");
            double y = x / 3;
            Console.WriteLine(y);

            Console.Write("Delene na modul na 3:     ");
            double z = x % 3;
            Console.WriteLine(z);

            int income = 10;
            Console.WriteLine(income+10);

           
        }
    }
}
