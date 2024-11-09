using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square squ = new Square(4);
            Triangle tri = new Triangle(7,5,6);
            Circle cir = new Circle(9);            

            Shape[] arrS = new Shape[] { squ, tri, cir };

            foreach (Shape s in arrS)
            {
                s.getPerimetr();
                s.getArea();                
                s.Show();                
            }

            tri.Move();
            squ.Move();
        }
    }
}
