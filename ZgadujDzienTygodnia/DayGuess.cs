using System;
using ZgadujDzienTygodnia.Core;

namespace ZgadujDzienTygodnia
{
    public class DayGuess
    {
        public DayCalculator Calculator { get; set; }
        public DateTimeOffset UserDateOfBirth { get; set; }//tu bedziemy przechowywać naszą date urodzenia
        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        //OPIS APLIKACI
        public void IntroduceTheAplication() { //wprowadzenie do aplikacji pokaże użytkownikowi do czego ona jest
            Console.WriteLine("Cześć! Aplikacja wylicza dzień tygodnia na podstawie daty urodzenia!");

            Calculator = new DayCalculator();
        }

        public void AskUserForTheirDateOfBirth() { //będziemy pytać użytkownika o date urodzenia
            Console.WriteLine("Podaj swoja date urodzenia abym mógł wyliczyc dzień tygodnia w formacie mm/dd/yyyy");
            var userDateBirth = Console.ReadLine();
            var success = DateTimeOffset.TryParse(userDateBirth, out var date);//parsujemy na date
            if(success)
            {
                UserDateOfBirth = date;
                return;
            } else
            {
                Console.WriteLine("Format daty był niepoprawny. Wpisz date jeszcze raz w formacie mm/dd/yyyy");
                AskUserForTheirDateOfBirth();
            }

            
        }

        public void CalculateDayOfTheWeek() {//bedziemy obliczac dzień na podstawie daty
            if(UserDateOfBirth==null)
            {
                Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty");
                return;
            }
            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }

        public void PrintDayOfTheWeek(){//będziemy wypisywać dzień tygodnia który wyliczyliśmy
            Console.WriteLine("Urodziłeś się w " + UserDayOfTheWeek.ToPolishString());
        }
    }
}
