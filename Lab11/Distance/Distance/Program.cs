using System;

namespace Distance
{
    
    internal class Program
    {
        // Метод для ввода данных
        static Distance enterData()
        {
            Console.Write($"Введите количество футов расстояния: ");
            int Foot = Int32.Parse(Console.ReadLine());
            Console.Write($"Введите количество дюймов расстояния: ");
            int Inch = Int32.Parse(Console.ReadLine());

            // Возвращаем область памяти, где хранятся данные 
            return new Distance(Foot, Inch); 
        }        
       
        static void Main(string[] args)
        {
            try
            {
                // Дистанция 1
                Distance dist1 = enterData();
                // Дистанция 2
                Distance dist2 = new Distance();
                // Сумма дистанции 1 и 2
                Distance distSum = dist1 + dist2;
                // Сумма дистанции 1 и 2
                Distance distDif = dist1 - dist2;

                Console.WriteLine(dist1);
                Console.WriteLine(dist2);
                Console.WriteLine(distSum);
                Console.WriteLine(distDif);

                Console.WriteLine("Дистанция 1 {0} Дистанция 2", dist1.Equals(dist2) ? "равно" : "не равно");
                Console.WriteLine("Дистанция 1 {0} Дистанция 2", dist1 == dist2 ? "равно" : "не равно");
                Console.WriteLine("Дистанция 1 {0} Дистанция 2", dist1 != dist2 ? "не равно" : "равно");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }            
        }
    }
}
