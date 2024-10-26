using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_shooting
{  
    internal class Program
    {  
        static void Main(string[] args)
        {           
            // Вариант мишени 2
            // Координаты выстрела
            int x = 0;
            int y = 0;
            // Набранная сумма очков после 3 выстрелов по мишени
            int res = 0;
            try
            {
                
                for (int i = 3; i > 0; i--)
                {
                    Console.Write("Введите координату выстрела по х: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите координату выстрела по y: ");
                    y = Int32.Parse(Console.ReadLine());

                    // Стрельба в слепую
                    double shift = new Random().Next(4);
                    Console.WriteLine($"Центр мишени смещен на {shift}");

                    // Трудность при выстреле
                    bool err = Convert.ToBoolean(new Random().Next(2));
                    if (err)
                    {
                        Console.WriteLine($"Произошла осечка в оружии, осталось {i - 1} выстрела");
                        Console.WriteLine("----------------------------------------------");
                        continue;
                    }

                    if (x * x + y * y + shift < 1)
                    {
                        Console.WriteLine("Попали в область 1");
                        res += 10;
                    }
                    else if (x * x + y * y + shift < 4)
                    {
                        Console.WriteLine("Попали в область 2");
                        res += 5;
                    }
                    else if (x * x + y * y + shift <= 9)
                    {
                        Console.WriteLine("Попали в область 3");
                        res += 1;
                    }
                    else
                    {
                        Console.WriteLine("Промах");
                    }
                    Console.WriteLine("----------------------------------------------");
                }
                Console.WriteLine($"Результат выстрелов {res} ");
                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}