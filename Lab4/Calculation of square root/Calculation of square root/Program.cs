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
        static double calcSquRoot()
        {
            return double.NaN;
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Пожалуйста, введите коэффициент a.");
            string s = Console.ReadLine();
            bool flag = double.TryParse(s, out a);

            Console.WriteLine("Пожалуйста, введите коэффициент b.");
            
            
           
            Console.WriteLine("Пожалуйста, введите коэффициент c.");
            

            
        }
    }
}
