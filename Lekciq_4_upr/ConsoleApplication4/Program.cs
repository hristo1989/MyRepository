﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Deleno na Y = ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Ostatuk: ");
            Console.WriteLine(x % y);

        }
    }
}
