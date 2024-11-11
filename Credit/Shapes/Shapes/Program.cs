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
            Console.WriteLine("-----------------------------------------Прямоугольник----------------------------------------------");
            Point A = new Point(1, 5);
            Point B = new Point(10, 5);
            Point C = new Point(10, 1);
            Point D = new Point(1, 1);
            Rectangle rec = new Rectangle(A, B, C, D);
            if (rec.isNotRectangle())
            {
                Console.WriteLine("Эта фигура не прямоугольник");
            }
            else
            {                
                rec.getPerimetr();
                rec.getArea();
                rec.Show();
            }

            Console.WriteLine("\n-------------------------------------------Квадрат--------------------------------------------------");
            Square squ = new Square(A, B, C, D);
            //Console.WriteLine("Эта фигура - квадрат? {0}", squ.IsNotSquare() ? "Нет" : "Да");

            squ.coordA = new Point(0,0);
            squ.coordB = new Point(0,4);
            squ.coordC = new Point(4,4);
            squ.coordD = new Point(4,0);
            
            if (squ.IsNotSquare())
            {
                Console.WriteLine("Эта фигура не квадрат");
            }
            else
            {
                squ.getPerimetr();
                squ.getArea();
                squ.Show();
            }            

            Console.WriteLine("\n-------------------------------------------Треугольник-------------------------------------------------");
            Triangle tri = new Triangle(A, B, C);
            //Console.WriteLine("Эта фигура - треугольник ? {0}", tri.isNotTriang() ? "Нет" : "Да");
            if (tri.isNotTriang())
            {
                Console.WriteLine("Эта фигура не треугольник");
            }
            else
            {
                tri.getPerimetr();
                tri.getArea();
                tri.Show();
            }            

            Console.WriteLine("\n------------------------------------Равностороний треугольник-------------------------------");
            A.X = 2;
            A.Y = 2;
            B.X = 4;
            B.Y = 4;
            C.X = 6;
            C.Y = 2;
            equTriang equTri = new equTriang(A, B, C);
            
            //Console.WriteLine("Эта фигура - равностороний треугольник ? {0}", equTri.IsNotEquTriang() ? "Нет" : "Да");
            if (equTri.IsNotEquTriang())
            {
                Console.WriteLine("Эта фигура не треугольник");
            }
            else
            {
                equTri.getPerimetr();
                equTri.getArea();
                equTri.Show();
            }           
            

            Console.WriteLine("\n-----------------------------------Окружность------------------------------------");

            Line line = new Line(A,B);
            Circle cir = new Circle(line);
            cir.getPerimetr();
            cir.getArea();
            cir.Show();

            Console.WriteLine("\n-----------------------------------Перемещение фигур------------------------------------");

            Console.WriteLine($" Координаты треугольника до пермещения: (.)А: X = {A.X}, Y = {A.Y}, (.)B: X = {B.X}, Y = {B.Y},(.)C: X = {C.X}, Y = {C.Y}");
            double distToX = 5;
            double distToY = 7;
            Console.WriteLine($" Сдвинем треугольник на X = {distToX}, Y = {distToY}");
            tri.Move(distToX, distToY);
            Console.WriteLine($" Координаты треугольника после перемещения: (.)А: X = {A.X}, Y = {A.Y}, (.)B: X = {B.X}, Y = {B.Y},(.)C: X = {C.X}, Y = {C.Y}");

            Console.WriteLine($"\n Координаты окружности центра до пермещения: X = {line.beginPoint.X}, Y = {line.beginPoint.Y}");
            distToX = 12;
            distToY = 32;
            Console.WriteLine($" Сдвинем центр окружности на X = {distToX}, Y = {distToY}");
            cir.Move(distToX, distToY);
            Console.WriteLine($" Координаты окружности центра после перемещения: X = {line.beginPoint.X}, Y = {line.beginPoint.Y}");
        }
    }
}
