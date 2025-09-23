using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.TenkeumiaffoSL.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        // пример линейной структуры
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        // пример линейной структуры
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
        // пример линейной структуры
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        // пример линейной структуры
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                // пример создан в целах демонстрации ветвления
                // в реалных проэктах нужно использовать Еxception
                Console.WriteLine("Перемеррая b = {0} на ноль делить нелзя", b);
                return -1; 
            }
            else

                return a / b;
        }
    }
}
