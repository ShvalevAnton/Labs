using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square:Shape, IOperation
    {
        private double Side;  // Сторона квадрата

        public double LengthSide
        {
            get => Side;
            set => Side = value;
        }
        public Square(double s) 
        {
            this.Side = s;
        }
        // Метод расчитывает периметр квадрата
        public override double getArea() => Area = Side * Side;
        
        // Метод расчитывает площадь квадрата
        public override double getPerimetr() => Perimetr = Side * 4;       

        public override void Show()
        {
            Console.WriteLine($"Параметры квадрата: Сторона: {Side}, Периметр: {Perimetr}, Площад: {Area}");
        }

        public void Move()
        {
            Console.WriteLine("Поворот квадрата");
        }
    }
}
