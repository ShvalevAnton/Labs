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

        public double LengthSideA
        {
            get => sA;
            set => sA = value;
        }
        public double LengthSideB
        {
            get => sB; 
            set => sB = value;
        }
        public double LengthSideC
        {
            get => sC;
            set => sC = value;
        }


        // Для создания равностороннего треугольника     
        public Triangle(double sA)
        {
            this.sA = sA;
            this.sB = sA;
            this.sC = sA;
            this.P = calculateP();
            this.S = calculateS();
        }

        // Для создания треугольника с заданными длинами сторон
        public Triangle(double sA, double sB, double sC)
        {
            this.sA = sA;
            this.sB = sB;
            this.sC = sC;
            this.P = calculateP();
            this.S = calculateS();
        }
       
        public double calculateP() => this.P = (sA + sB + sC) / 2;
        public double calculateS() => this.S = Math.Sqrt(P * (P - sA) * (P - sB) * (P - sC));    
        
        // Проверка на треугольник
        public bool isNotTriang() => (sA + sB <= sC) || (sA + sC <= sB) || (sC + sB <= sA);
        
        // Выводить длины сторон треугольника на экран;
        public override string ToString() => $"Сторона А: {sA}, Сторона B: {sB}, Сторона C: {sC}, Периметр: {P}, Площадь: {S}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо определить площадь треугольника.\nУкажите тип треугольника: 1 — равнобедренный, 2 — разносторонний.");

            int typeTriang = Int32.Parse(Console.ReadLine());
            if (typeTriang != 1 && typeTriang != 2)
            {
                throw new Exception("Выбран не верный тип треугольника!");
            }
            Triangle triangle;
            if (typeTriang == 1)
            {                
                // Длинна стороны А треугольника
                Console.WriteLine("Пожалуйста, напишите длину стороны равнобедренного треугольника.");
                double sideA = Int32.Parse(Console.ReadLine());               
                triangle = new Triangle(sideA);
            }
            else
            {
                // Длинна стороны А треугольника
                Console.WriteLine("Пожалуйста, напишите длину стороны А разностороннего треугольника.");
                double sideA = Int32.Parse(Console.ReadLine());
                // Длинна стороны B треугольника
                Console.WriteLine("Пожалуйста, напишите длину стороны В разностороннего треугольника.");
                double sideB = Int32.Parse(Console.ReadLine());
                // Длинна стороны C треугольника
                Console.WriteLine("Пожалуйста, напишите длину стороны С разностороннего треугольника.");
                double sideC = Int32.Parse(Console.ReadLine());
                
                triangle = new Triangle(sideA, sideB, sideC);                
            }

            if (triangle.isNotTriang())
            {
                throw new Exception("Введенные точки не образуют треугольник.");
            }
            Console.WriteLine(triangle);

        }
    }
}
