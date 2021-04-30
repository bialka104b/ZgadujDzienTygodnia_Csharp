using System;

namespace ZgadujDzienTygodnia
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new DayGuess();

            guesser.IntroduceTheAplication();
            guesser.AskUserForTheirDateOfBirth();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}
