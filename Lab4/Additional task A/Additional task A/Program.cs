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
        static public double calcSquRoot(double target)
        {
            double x = 1;
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

            // Вызов метода с передачей результата другой переменной.
            double x = calcSquRoot(target);

            // Вывод результата (x) и проверочного значения (x*x) на экран.
            Console.WriteLine(x);
            Console.WriteLine(x * x);
        }
    }    
}
