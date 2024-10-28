namespace Utils
{
    using System;

    public class Utils
    {
        static public int Greater (int a, int b)
        {
            return a > b ? a : b;
        }
        static public void Swap(ref int a,ref int b)  // передача аргумента по ссылке         
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static public void Swap(int a, int b)       // передача аргумента по значению 
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static public bool Factorial(int n, out int answer)
        {
            int k; // Loop counter
            int f; // Working value
            bool ok = true; // True if okay, false if not                        
            if (n < 0)  // Check the input value
                ok = false;
            // Calculate the factorial value as the
            // product of all of the numbers from 2 to n
            try
            {
                checked // проверка на переполнение
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
                //f = 1;
                //for (k = 2; k <= n; ++k)
                //{
                //    f = f * k;
                //}
            }
            catch (OverflowException e)
            {
                f = 0;
                ok = false;
                Console.WriteLine(e.ToString());
            }
            answer = f;
            return ok;
        }




        // Write your methods in here
    }
}
