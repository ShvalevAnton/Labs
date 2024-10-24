using System;

namespace Distance
{
    public struct Distance
    {
        public int foot;   // фут
        public int inch;   // дюйм
        public Distance(int foot, int inch)
        {
            this.foot = foot;
            this.inch = inch;
        }
    }
    internal class Program
    {
        // Метод для ввода данных
        static Distance enterData(int numDist)
        {
            Console.Write($"Введите количество футов расстояния {numDist}: ");
            int Foot = Int32.Parse(Console.ReadLine());
            Console.Write($"Введите количество дюймов расстояния {numDist}: ");
            int Inch = Int32.Parse(Console.ReadLine());

            // Возвращаем ссылку на область памяти, где хранятся данные (как я это представляю)
            return new Distance(Foot, Inch); 
        }
        // Метод для вычисления суммы расстояний 1 и 2
        static Distance Mathematics(Distance dist1, Distance dist2)
        {
            // Переводим все данные в дюймы и считаем сумму двух дистанций в дюймах  
            int sum = dist1.foot * 12 + dist1.inch + dist2.foot * 12 + dist2.inch;
            // Подсчитываем количество футов
            int foot = sum / 12;
            // Подсчитываем количество дюймов
            int inch = sum % 12;

            // Возвращаем ссылку на область памяти, где хранятся данные (как я это представляю)
            return new Distance(foot, inch);
        }
        static void Main(string[] args)
        {
            try
            {
                // Дистанция 1
                Distance dist1 = enterData(1);
                // Дистанция 2
                Distance dist2 = enterData(2);
                // Сумма дистанции 1 и 2
                Distance distSum = Mathematics(dist1, dist2);
                Console.WriteLine($"Сумма первой и второй дистанции равна: {distSum.foot}\'-{distSum.inch}\""); 
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
        }
    }
}
