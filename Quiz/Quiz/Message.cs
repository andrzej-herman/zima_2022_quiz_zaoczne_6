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
            Console.WriteLine();
            Console.WriteLine("WITAJ W QUZIE WIEDZY GRUPY 6");
            Console.WriteLine("Spróbuj odpowiedzieć n a7 pytań");
            Console.WriteLine("POWODZENIA !!!!");
            Console.WriteLine();
            Console.Write("Naciśnij ENTER, aby rozpocząć grę ...");
            Console.ReadLine();
        }
    }
}
