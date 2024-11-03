using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Triangle
    {
        private double sA;  // Сторона треугольника А
        private double sB;  // Сторона треугольника B
        private double sC;  // Сторона треугольника С
        private double P;   // Периметр треугольника
        private double S;   // Площадь треугольника

        // Конструктор
        public Triangle(){ }

        public Triangle(double sA, double sB, double sC)
        {
            this.sA = sA;
            this.sB = sB;
            this.sC = sC;
            this.P = calculateP();
            this.S = calculateS();
        }

        public void LengthSideA(double sA) => this.sA= sA;
        public void LengthSideB(double sB) => this.sB= sB;
        public void LengthSideC(double sC) => this.sC = sC;
        public double calculateP() => this.P = (sA + sB + sC) / 2;
        public double calculateS() => this.S = Math.Sqrt(P * (P - sA) * (P - sB) * (P - sC));    
        
        // Проверка на треугольник
        static public bool isTriang(Triangle tri) => (tri.sA + tri.sB <= tri.sC) || (tri.sA + tri.sC <= tri.sB) || (tri.sC + tri.sB <= tri.sA);
        
        // Выводить длины сторон треугольника на экран;
        public override string ToString() => $"Сторона А: {sA}, Сторона B: {sB}, Сторона C: {sC}.";
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            Triangle t1 = new Triangle();
            // Длинна стороны А треугольника
            Console.WriteLine("Пожалуйста, напишите длину стороны А треугольника.");
            t1.LengthSideA(double.Parse(Console.ReadLine()));
            // Длинна стороны B треугольника
            Console.WriteLine("Пожалуйста, напишите длину стороны В треугольника.");
            t1.LengthSideB(double.Parse(Console.ReadLine()));
            // Длинна стороны C треугольника
            Console.WriteLine("Пожалуйста, напишите длину стороны С треугольника.");
            t1.LengthSideC(double.Parse(Console.ReadLine()));

            if (Triangle.isTriang(t1))
            {
                throw new Exception("Введенные точки не образуют треугольник.");
            }
            Console.WriteLine(t1);
            Console.WriteLine($"Периметр треугольника: {t1.calculateP()}, площадь треугольника: {t1.calculateS()}");


            Triangle t2 = new Triangle(4,-6,8);
            if (Triangle.isTriang(t2))
            {
                throw new Exception("Введенные точки не образуют треугольник.");
            }
            Console.WriteLine(t2);
            Console.WriteLine($"Периметр треугольника: {t2.calculateP()}, площадь треугольника: {t2.calculateS()}");
        }
    }
}
