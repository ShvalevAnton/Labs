using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // Равностороний
     class equTriang:Triangle
    {

        // Конструктор без параметров
        public equTriang() : base() { }

        // Конструктор c параметром
        public equTriang(Point A, Point B, Point C) : base(A, B, C) { }
        // Конструктор копирования
        public equTriang(equTriang equTri) : base(equTri) { }

        // Проверка на равностороний треугольник
        public bool IsNotEquTriang() => base.isNotTriang() & (base.getAB != base.getBC || base.getBC != base.getCA || base.getCA != base.getAB);
        public override void Show()
        {
            Console.WriteLine($"Параметры равностороннего треугольника: Сторона АB: {getAB:F2}, Сторона BC: {getBC:F2}, Сторона CA: {getCA:F2}, Периметр: {getPerimetr():F2}, Площадь: {getArea():F2}");
        }
    }
}
