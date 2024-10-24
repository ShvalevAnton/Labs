using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    internal class DivideIt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer");       
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer");
            int j = Int32.Parse(Console.ReadLine());
            int k = i / j;
            Console.WriteLine($"The result of dividing {i} by {j} is {k}");
        }
    }
}
