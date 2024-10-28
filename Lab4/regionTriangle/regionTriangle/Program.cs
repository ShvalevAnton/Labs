using System;

namespace regionTriangle
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Необходимо определить площадь треугольника.\nУкажите тип треугольника: 1 — равнобедренный, 2 — разносторонний.");              

                int typeTriang = Int32.Parse(Console.ReadLine());
                if (typeTriang != 1 && typeTriang != 2)
                {
                    throw new Exception("Выбран не верный тип треугольника!");
                }

                int sideA = 0;
                int sideB = 0;
                int sideC = 0; 
                if (typeTriang == 1)
                {
                    // Длинна стороны А треугольника
                    Console.WriteLine("Пожалуйста, напишите длину стороны равнобедренного треугольника.");
                    sideA = Int32.Parse(Console.ReadLine());
                    double squTriang = Operation.CalcSquTriang(sideA);
                    Console.WriteLine($"Площадь треугольника = {squTriang}.");
                }
                else if (typeTriang == 2)
                {
                    // Длинна стороны А треугольника
                    Console.WriteLine("Пожалуйста, напишите длину стороны А разностороннего треугольника.");
                    sideA = Int32.Parse(Console.ReadLine());
                    // Длинна стороны B треугольника
                    Console.WriteLine("Пожалуйста, напишите длину стороны В разностороннего треугольника.");
                    sideB = Int32.Parse(Console.ReadLine());
                    // Длинна стороны C треугольника
                    Console.WriteLine("Пожалуйста, напишите длину стороны С разностороннего треугольника.");
                    sideC = Int32.Parse(Console.ReadLine());

                    double squTriang = Operation.CalcSquTriang(sideA, sideB, sideC);                    
                    Console.WriteLine($"Площадь треугольника = {squTriang}.");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
