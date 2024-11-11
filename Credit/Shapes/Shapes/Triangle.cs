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
        private Point A = new Point();
        private Point B = new Point();
        private Point C = new Point();

        public Point coordA
        {
            get => A;
            set => A = value;
        }
        public Point coordB
        {
            get => B;
            set => B = value;
        }
        public Point coordC
        {
            get => C;
            set => C = value;
        }

        // Конструктор без параметров
        public Triangle() { }
        // Конструктор с параметров
        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        // Конструктор копирования
        public Triangle(Triangle T)
        {
            this.A = T.A;
            this.B = T.B;
            this.C = T.C;
        }

        // Длина стороны AB
        public double getAB { get => Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)); }
        // Длина стороны BC
        public double getBC { get => Math.Sqrt((B.X - C.X) * (B.X - C.X) + (B.Y - C.Y) * (B.Y - C.Y)); }
        // Длина стороны CA
        public double getCA { get => Math.Sqrt((C.X - A.X) * (C.X - A.X) + (C.Y - A.Y) * (C.Y - A.Y)); }
                
        
        // Метод расчитывает периметр треугольника
        public override double getPerimetr() => (getAB + getBC + getCA) / 2;

        // Метод расчитывает площадь треугольника
        public override double getArea() => Math.Sqrt(getPerimetr() * (getPerimetr() - getAB) * (getPerimetr() - getBC) * (getPerimetr() - getCA));
        
        // Проверка на треугольник
        public bool isNotTriang() => (getAB + getBC <= getCA) || (getAB + getCA <= getBC) || (getCA + getBC <= getAB);
        
        public override void Show()
        {
            Console.WriteLine($"Параметры треугольника: Сторона АB: {getAB:F2}, Сторона BC: {getBC:F2}, Сторона CA: {getCA:F2}, Периметр: {getPerimetr():F2}, Площадь: {getArea():F2}");
        }    

        public void Move(double mX, double mY)
        {
            this.A.Move(mX, mY);
            this.B.Move(mX, mY);
            this.C.Move(mX, mY);
        }         
    }
}
