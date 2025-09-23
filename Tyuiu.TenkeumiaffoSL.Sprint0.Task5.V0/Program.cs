using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TenkeumiaffoSL.Sprint0.Task5.V0.Lib; 
namespace Tyuiu.TenkeumiaffoSL.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            // пример разветвляюцейся структуры находится в библиотеке классов в методе division
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadKey();
        }

    }
}
