using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    abstract class Shape
    {
        protected double Perimetr;   // Периметр квадрата
        protected double Area;   // Площадь квадрата 

        abstract public double getPerimetr();
        abstract public double getArea();
        abstract public void Show();
    }
}
