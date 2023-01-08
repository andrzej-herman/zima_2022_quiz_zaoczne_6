using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Message
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("WITAJ W QUZIE WIEDZY GRUPY 6");
            Console.WriteLine("Spróbuj odpowiedzieć n a7 pytań");
            Console.WriteLine("POWODZENIA !!!!");
            Console.WriteLine();
            Console.Write("Naciśnij ENTER, aby rozpocząć grę ...");
            Console.ReadLine();
        }

        public void QuizFail()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("NIESTETY, TO NIE JEST PRAWIDŁOWA ODPOWIEDŹ ...");
            Console.WriteLine("KONIEC GRY !!!!");
            Console.WriteLine();
        }



        public void FinalScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO, UDAŁO CI SIĘ UKOŃCZYĆ QUIZ !!!");
            Console.WriteLine("KONIEC GRY !!!!");
            Console.WriteLine();
            Console.ReadLine();
        }


        public void GoodAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO, TO PRAWIDŁOWA ODPOWIEDŹ !!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nacisnij ENTER, aby zobaczyć nastepne pytanie ...");
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}
