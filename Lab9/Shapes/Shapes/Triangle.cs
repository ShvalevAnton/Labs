using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle:Shape, IOperation
    {
        private double sideA;  // Сторона треугольника А
        private double sideB;  // Сторона треугольника B
        private double sideC;  // Сторона треугольника С       

        public double LengthSideA
        {
            get => sideA;
            set => sideA = value;
        }
        public double LengthSideB
        {
            get => sideB;
            set => sideB = value;
        }
        public double LengthSideC
        {
            get => sideC;
            set => sideC = value;
        }
        // Для создания равностороннего треугольника   
        public Triangle(double sA)
        {
            this.sideA = sA;
            this.sideB = sA;
            this.sideC = sA;
        }
        // Для создания треугольника с заданными длинами сторон
        public Triangle(double sA, double sB, double sC)
        {
            this.sideA = sA;
            this.sideB = sB;
            this.sideC = sC;            
        }
        // Метод расчитывает периметр треугольника
        public override double getPerimetr() => this.Perimetr = (sideA + sideB + sideC) / 2;

        // Метод расчитывает площадь треугольника
        public override double getArea() => this.Area = Math.Sqrt(Perimetr * (Perimetr - sideA) * (Perimetr - sideB) * (Perimetr - sideC));
        
        // Проверка на треугольник
        public bool isNotTriang() => (sideA + sideB <= sideC) || (sideA + sideC <= sideB) || (sideC + sideB <= sideA);
        
        public override void Show()
        {
            Console.WriteLine($"Параметры треугольника: Сторона А: {sideA}, Сторона B: {sideB}, Сторона C: {sideC}, Периметр: {Perimetr}, Площадь: {Area}");
        }

        public void Move()
        {
            Console.WriteLine("Поворот треугольника");
        }
    }
}
