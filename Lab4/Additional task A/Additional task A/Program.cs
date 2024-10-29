using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task_A
{
    internal class Program
    {
        // Статический метод расчета 
        static public double calcSquRoot(double target, ref double x)
        {            
            double oldx;
            do
            {
                oldx = x;
                x = (x + target / x) / 2;
            }
            while (oldx != x);
            return x;
        }
        static void Main(string[] args)
        {
            double target = 2023;
            // Объявление и инициализация переменной, для которой требуется определить квадратный корень.
            double x = 1;

            // Вызов метода с передачей результата другой переменной.
            double y = calcSquRoot(target,ref x);

            // Вывод результата (x) и проверочного значения (x*x) на экран.
            Console.WriteLine(x);
            Console.WriteLine(x * x);
        }
    }    
}
