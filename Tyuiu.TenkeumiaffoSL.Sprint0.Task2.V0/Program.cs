﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TenkeumiaffoSL.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выброп класса DataService и метода GetMessage
            // из библиотеки Tyuiu.TenkeumiaffoSL.Sprint0.Task2.V0
            Console.WriteLine(DataService.GetMessage("Samuel"));
            Console.ReadKey();
           
        }
    }
}
