namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {

            // Put your test code in here	
            //Console.Write("a = " );
            //int x = Int32.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int y = Int32.Parse(Console.ReadLine());
            //int greater = Utils.Greater(x, y);

            //Console.WriteLine("\n---------Передача по значению--------------");
            //Console.WriteLine("Before swap: a = " + x + ", b = " + y);
            //Utils.Swap(x, y);   // передача аргумента по значению 
            //Console.WriteLine("After swap: a = " + x + ", b =" + y);

            //Console.WriteLine("\n---------Передача по ссылке--------------"); 
            //Console.WriteLine("Before swap: a = " + x + ", b = " + y);
            //Console.WriteLine("Before swap: a = " + x + ", b = " + y);
            //Utils.Swap(ref x, ref y); // передача аргумента по ссылке            
            //Console.WriteLine("After swap: a = " + x + ", b =" + y);

            int f; // Factorial result
            bool ok; // Factorial success or failure
            Console.WriteLine("Number for factorial:");
            int x = int.Parse(Console.ReadLine());
            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");


        }

    }
}
