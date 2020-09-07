using System;

namespace Guestbook
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is the Guestbook! Type an optional message followed by your name or credentials.");
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") + ": Martina was here!");
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") + ": Martina was here again!");
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") + ": David Crosson was here!");
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") + ": Nikola Pavlovic was here!");


        }
    }
}
