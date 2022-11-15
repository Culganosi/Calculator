using System;

namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string appName = "Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Culgan";

            // Change Console Text Color
            Console.ForegroundColor= ConsoleColor.Green;
            
            // Write App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change Console Text Color back to White
            Console.ResetColor();
        }
    }
}