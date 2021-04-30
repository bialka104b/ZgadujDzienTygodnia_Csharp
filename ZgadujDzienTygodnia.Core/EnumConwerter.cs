using System;
using System.Collections.Generic;
using System.Text;

namespace ZgadujDzienTygodnia.Core
{
    public static class EnumConwerter
    {
        public static string ToPolishString(this DayOfTheWeek enumDayOfTheWeek) { 
            switch(enumDayOfTheWeek)
            {
                case 0:
                    return "Poniedziałek";
                case (DayOfTheWeek)1:
                    return "Wtorek";
                case (DayOfTheWeek)2:
                    return "Środa";
                case (DayOfTheWeek)3:
                    return "Czwartek";
                case (DayOfTheWeek)4:
                    return "Piątek";
                case (DayOfTheWeek)5:
                    return "Sobota";
                case (DayOfTheWeek)6:
                    return "Niedziela";
                default:
                    return "poniedziałek";
            }
        }
    }
}
