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

            int x = int.Parse(Console.ReadLine());
            //kogato vuvejdame chislo s funkciqt int izpolzvame konvertor int.Parse za da razpoznae vuvedenoto chislo//

            Console.WriteLine(x);


        }
    }
}
