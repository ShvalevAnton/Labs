using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     class Rectangle: Shape, IOperation
    {
        private Point A = new Point(); 
        private Point B = new Point(); 
        private Point C = new Point();
        private Point D = new Point();
       
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
        public Point coordD
        {
            get => D;
            set => D = value;
        }
        // Конструктор без параметров
        public Rectangle() { }
        // Конструктор с параметров
        public Rectangle(Point A, Point B, Point C, Point D) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        // Конструктор копирования
        public Rectangle(Rectangle R)
        {
            this.A = R.A;
            this.B = R.B;
            this.C = R.C;
            this.D = R.D;
        }
        // Длина прямоугольника
        public double getLength { get => Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)); }
        
        // Ширина прямоугольника
        public double getWidth { get => Math.Sqrt((B.X - C.X) * (B.X - C.X) + (B.Y - C.Y) * (B.Y - C.Y)); } 

        // Метод расчитывает периметр прямоугольника
        public override double getArea() =>  getLength * getWidth;

        // Метод расчитывает площадь квадрата
        public override double getPerimetr() => getLength * 2 + getWidth * 2;

        public override void Show()
        {
            Console.WriteLine($"Параметры прямоуголника: Длинна: {getLength:F2}, Ширина: {getWidth:F2} Периметр: {getPerimetr():F2}, Площад: {getArea():F2}");
        }
        
        // Перемещение фигуры
        public void Move(double mX, double mY)
        {
            this.A.Move(mX, mY);
            this.B.Move(mX, mY);
            this.C.Move(mX, mY);
            this.D.Move(mX, mY);
        }

        public bool isNotRectangle()
        {
            double AB = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            double BC = Math.Sqrt((B.X - C.X) * (B.X - C.X) + (B.Y - C.Y) * (B.Y - C.Y));
            double DC = Math.Sqrt((D.X - C.X) * (D.X - C.X) + (D.Y - C.Y) * (D.Y - C.Y));
            double AD = Math.Sqrt((A.X - D.X) * (A.X - D.X) + (A.Y - D.Y) * (A.Y - D.Y));

            return (AB != DC) & (BC != AD);
        }
    }
}
