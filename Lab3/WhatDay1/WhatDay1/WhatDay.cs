﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        static void Main(string[] args)
        {
            Console.Write("Please enter a day number between 1 and 365: ");
            int dayNum = int.Parse(Console.ReadLine());            
            int monthNum = 0;
            int DaysInMonths = DateTime.DaysInMonth(dayNum, monthNum);
            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
            Console.WriteLine("{0} {1}", dayNum, monthName);



        }
    }
}
