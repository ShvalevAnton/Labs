using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     class Point : IOperation
    {
        private double x;  
        private double y;  

        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }

        // Конструктор без параметров        
        public Point() { }

        // Конструктор c параметрами
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Конструктор копирования
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        // Перемещение точки
        public void Move(double mX, double mY)
        {
            this.X = this.X + mX;
            this.Y = this.Y + mY;            
        }
        
    }
}
