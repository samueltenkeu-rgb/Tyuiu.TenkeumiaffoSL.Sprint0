using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.TenkeumiaffoSL.Sprint0.Task4.V0.Lib; 
namespace Tyuiu.TenkeumiaffoSL.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // пример линейной структуры
            // вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            // вызов метода вычитания Substraction
            Console.WriteLine(DataService.Substraction(10, 5));
            // вызов метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            // вызов метода деления Division
            Console.WriteLine(DataService.Division(5, 5));


            Console.ReadKey();
        }
    }
}
