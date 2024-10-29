using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_square_root
{
    internal class Program
    {
        static public int calcSquRoot(double a, double b, double c, out double x1, out double x2)
        {
            double D = Math.Pow(b,2) - (4 * a * c);
            x1 = (-b - Math.Sqrt(D)) / (2 * a);
            x2 = (-b + Math.Sqrt(D)) / (2 * a);

            // у квадратного уравнения два корня
            if (D > 0)
            {
                return 1;
            }
            // у квадратного уравнения один корень
            else if (D == 0)
            {
                return 0;
            }
            // у квадратного уравнения нет корней
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Пожалуйста, введите коэффициент a.");
            string s = Console.ReadLine();
            bool flag = double.TryParse(s, out a);
            if (!flag)
            {
                Console.WriteLine("Введенны не верные данные!");
                return;
            }

            Console.WriteLine("Пожалуйста, введите коэффициент b.");
            s = Console.ReadLine();
            double b;
            flag = double.TryParse(s, out b);
            if (!flag)
            {
                Console.WriteLine("Введенны не верные данные!");
                return;
            }
            Console.WriteLine("Пожалуйста, введите коэффициент c.");
            s = Console.ReadLine();
            double c;
            flag = double.TryParse(s, out c);
            if (!flag)
            {
                Console.WriteLine("Введенны не верные данные!");
                return;
            }
          
            double x1, x2;
            int res = calcSquRoot(a,b,c, out x1, out x2);
            switch (res)
            {
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет.");
                    break;
                case 0:
                    double d = double.IsNaN(x1) ? x2 : x1;
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} один: x1 = x2 = " + d.ToString());                                    
                    break;
                case 1:
                    Console.WriteLine($"Корень уравнения с коэффициентами  a = {a}, b = {b}, c = {c} равны: x1 = {x1}, x2 = {x2}.");
                    break;
            }       
        }
    }
}
