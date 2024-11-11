using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle: Shape, IOperation
    {
        private Line Rad = new Line(); // Радиус окружности       

        public Line Radius
        {
            get => Rad;
            set => Rad = value;
        }

        // Конструктор без параметров
        public Circle() { }
        // Конструктор с параметров
        public Circle(Line Rad)
        {
           this.Rad = Rad;
        }
        // Конструктор копирования
        public Circle(Circle C)
        {
            this.Rad = C.Rad;           
        }

        // Метод расчитывает периметр окружности
        public override double getPerimetr() => 2 * Math.PI * Radius.getLength;

        // Метод расчитывает площадь окружости
        public override double getArea() => Math.PI * Math.Pow(Radius.getLength, 2);

        public override void Show()
        {
            Console.WriteLine($"Параметры окружности: Радиус: {Radius.getLength:F2}, Периметр: {getPerimetr():F2}, Площадь: {getArea():F2}");
        
        }

        public void Move(double mX, double mY)
        {
            Radius.Move(mX, mY);
        }
    }

    
}
