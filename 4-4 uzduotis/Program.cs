﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            var Pirmas =    Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu");
            var Antras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Pirmas + Antras);

        }
    }
}
