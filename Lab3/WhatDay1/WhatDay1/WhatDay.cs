using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay1
{
    public enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class WhatDay
    {
        // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
            //= new char [4] {'d','f','g','r'}; 
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static System.Collections.ICollection DaysInLeapMonths
            = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Please enter the year: ");
                    int yearNum = int.Parse(Console.ReadLine());
                    // Проверка на высокосный год
                    bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                    int maxDayNum = isLeapYear ? 366 : 365;

                    if (isLeapYear)
                    {
                        Console.WriteLine(" IS a leap year"); // высокосный год
                    }
                    else
                    {
                        Console.WriteLine(" is NOT a leap year");// не высокосный год
                    }

                    Console.Write($"Please enter a day number between 1 and {maxDayNum}: ");
                    int dayNum = int.Parse(Console.ReadLine());
                    if (dayNum < 1 || dayNum > maxDayNum)
                    {
                        throw new ArgumentOutOfRangeException("Day out of range");
                    }
                    int monthNum = 0;

                    if (isLeapYear)
                    {
                        // считаем месяци и день для высокосного года
                        foreach (int daysInMonth in DaysInLeapMonths)
                        {
                            if (dayNum <= daysInMonth)
                            {
                                break;
                            }
                            else
                            {
                                // Считает дни в году
                                dayNum -= daysInMonth;
                                // Считает месяц в году
                                monthNum++;
                            }
                        }
                    }
                    else
                    {
                        // считаем месяци и день для не высокосного года
                        foreach (int daysInMonth in DaysInMonths)
                        {
                            if (dayNum <= daysInMonth)
                            {
                                break;
                            }
                            else
                            {
                                // Считает дни в году
                                dayNum -= daysInMonth;
                                // Считает месяц в году
                                monthNum++;
                            }
                        }
                    }
                    MonthName temp = (MonthName)monthNum;
                    string monthName = temp.ToString();
                    Console.WriteLine("{0} {1}", dayNum, monthName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
