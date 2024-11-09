using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle: Shape
    {
        private double Radius;   // Радиус окружности        

        public double LengthRadius
        {
            get => Radius;
            set => Radius = value;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
      
        // Метод расчитывает периметр окружности
        public override double getPerimetr() => Perimetr = 2 * Math.PI * Radius;

        // Метод расчитывает площадь окружости
        public override double getArea() => Area = Math.PI * Math.Pow(Radius, 2);

        public override void Show()
        {
            Console.WriteLine($"Параметры окружности: Радиус: {Radius}, Периметр: {Perimetr}, Площадь: {Area}");
        }
    }

    
}
