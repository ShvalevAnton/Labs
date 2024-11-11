using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     class Line
    {
        private Point Begin = new Point();
        private Point End = new Point();

        public Point beginPoint
        {
            get => Begin;
            set => Begin = value;
        }
        public Point endPoint
        {
            get => End;
            set => End = value;
        }
        
        // Конструктор без параметров
        public Line() { }

        // Конструктор c параметров 
        public Line(Point begin, Point end)
        {
            this.Begin = begin;
            this.End = end;
        }
        // Конструктор копирования
        public Line(Line l)
        {
            this.Begin = l.Begin;
            this.End = l.End;
        }
        // Длина линии
        public double getLength { get => Math.Sqrt((End.X - Begin.X) * (End.X - Begin.X) + (End.Y - Begin.Y) * (End.Y - Begin.Y)); }
      
        // Перемещение фигуры
        public void Move(double mX, double mY)
        {
            Begin.Move(mX, mY);
            End.Move(mX, mY);
        }
    }
        
}
