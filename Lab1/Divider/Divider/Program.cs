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
            try
            {
                Console.WriteLine("Please enter the first integer");
                int i = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second integer");
                int j = Int32.Parse(Console.ReadLine());
                int k = i / j;
                Console.WriteLine($"The result of dividing {i} by {j} is {k}");
            }
            catch(FormatException e) 
            {
                Console.WriteLine($"An format exception was thrown: {e.Message} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An exception was thrown: {e.Message} ");
            }
        }
    }
}
