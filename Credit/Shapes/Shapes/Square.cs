using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     class Square: Rectangle
    {
        // Конструктор без параметров
        public Square() : base() { }
        // Конструктор c параметром
        public Square(Point A, Point B, Point C, Point D) :base(A,B,C,D) { }

        // Конструктор копирования        
        public Square(Square squ) : base(squ) { }

        // Проверка на квадрат
        public bool IsNotSquare() => base.getLength != base.getWidth;
        public override void Show() => Console.WriteLine($"Параметры квадрата: Сторона: {base.getLength:F2}, Периметр: {base.getPerimetr():F2}, Площад: {base.getArea():F2}");        
    }
}
