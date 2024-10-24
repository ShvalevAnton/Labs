using System;

namespace regionTriangle
{
    internal class Program
    {
        // Метод для вывода данных на экран
        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        // Метод для расчета площади треугольника по формуле Герона
        static double CalcSquTriang(double sA, double sB, double sC)
        {
            // Периметр треугольника
            double P = (sA + sB + sC) / 2.0;
            // Площадь треугольника
            double squT = Math.Sqrt(P * (P - sA) * (P - sB) * (P - sC));
            return squT;
        }
        static void Main(string[] args)
        {
            try
            {
                // Длинна стороны А треугольника
                Print("Please write the length of side A of the triangle.");
                int sideA = Int32.Parse(Console.ReadLine());
                // Длинна стороны B треугольника
                Print("Please write the length of side B of the triangle.");
                int sideB = Int32.Parse(Console.ReadLine());
                // Длинна стороны C треугольника
                Print("Please write the length of side C of the triangle.");
                int sideC = Int32.Parse(Console.ReadLine());               
                double squTriangl = CalcSquTriang(sideA, sideB, sideC);
                Print($"Сторона   Площадь \n{sideA,7:f}   {squTriangl,7:f}\n{sideB,7:f}\n{sideC,7:f}" );
            }
            catch (FormatException)
            {
                Print("Error! Data entered incorrectly!");
            }          
        }

    }
}
