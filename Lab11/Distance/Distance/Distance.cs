using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    internal class Distance
    {
        public int foot;   // фут
        public int inch;   // дюйм

        public Distance()
        {
            foot = 4;
            inch = 9;
        }
        public Distance(int foot, int inch)
        {
            this.foot = foot;
            this.inch = inch;
        }

        public static Distance operator + (Distance dist1, Distance dist2)
        {
            // Переводим все данные в дюймы и считаем сумму двух дистанций в дюймах
            int sum = dist1.foot * 12 + dist1.inch + dist2.foot * 12 + dist2.inch;
            // Подсчитываем количество футов
            int foot = sum / 12;
            // Подсчитываем количество дюймов
            int inch = sum % 12;

            // Возвращаем область памяти, где хранятся данные
            return new Distance(foot, inch);
        }

        public static Distance operator -(Distance dist1, Distance dist2)
        {
            // Переводим все данные в дюймы и считаем сумму двух дистанций в дюймах
            int dif = dist1.foot * 12 - dist1.inch - dist2.foot * 12 - dist2.inch;
            // Подсчитываем количество футов
            int foot = dif / 12;
            // Подсчитываем количество дюймов
            int inch = dif % 12;
            
            // Возвращаем область памяти, где хранятся данные
            return new Distance(foot, inch);
        }

        public override bool Equals(Object obj)
        {
            // Локальная объектная переменная
            Distance d = (Distance) obj;
            
            // Переводим все данные в дюймы и сравниваем дистанции
            int dist1 = foot * 12 + inch;
            int dist2 = d.foot * 12 + d.inch;

            return dist1 == dist2;          
        }

        public static bool operator ==(Distance dist1, Distance dist2)
        {
            return dist1.Equals(dist2);
        }

        public static bool operator !=(Distance dist1, Distance dist2)
        {
            return !(dist1 == dist2);
        }

        public override string ToString() => $"Сумма первой и второй дистанции равна: {foot}\'-{inch}\"";
    }
}
