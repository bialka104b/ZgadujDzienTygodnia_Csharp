using System;
using System.Collections.Generic;

namespace ZgadujDzienTygodnia.Core
{
    public class DayCalculator
    {
        public DayOfTheWeek CalculateDayOfTheWeek(DateTimeOffset date) // funkcja przyjmuje date i zwraca dzień tygodnia
        {
            var day = date.Day;
            var month = date.Month;
            var year = date.Year;
            var listParameters = new List<int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (month < 3)
            {
                year -= 1;
            }
            var calculatedValue = (year + year / 4 - year / 100 + year / 400 + listParameters[month - 1] + day) % 7;
            Console.WriteLine(calculatedValue);
            return (DayOfTheWeek)(calculatedValue - 1);//rzutowanie na enuma
        }
    }
}
