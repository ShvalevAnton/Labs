using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regionTriangle
{
    internal class Operation
    {
        // Статический открытый метод для расчета площади треугольника по формуле Герона
        static public double CalcSquTriang(double sA, double sB, double sC)
        {           
            if (Operation.isTriang(sA, sB, sC))
            {
                throw new Exception("Введенные точки не образуют треугольник.");
            }
            // Периметр треугольника
            double P = (sA + sB + sC) / 2.0;
            // Площадь треугольника
            double squT = Math.Sqrt(P * (P - sA) * (P - sB) * (P - sC));           
            return squT;
        }

        // Статический открытый метод для расчета площади равностороннего треугольника по формуле Герона
        static public double CalcSquTriang(double sA)
        {
            // Периметр треугольника
            double P = (sA * 3) / 2.0;
            // Площадь треугольника
            double squT = Math.Sqrt(P * (P - sA) * 3);            
            return squT;
        }
        // Проверка на треугольник
        static bool isTriang(double sA, double sB, double sC)
        {
            return (sA + sB <= sC) || (sA + sC <= sB) || (sC + sB <= sA);
        }

    }
}
