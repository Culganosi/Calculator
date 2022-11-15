namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetInfo();
            StartGame();

            while (true)
            {
                // Set a random correct answer
                Random random = new Random();

                int correctAnswer = random.Next(1, 11);

                // Set a guess variable
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctAnswer)
                {
                    // Get guess from user
                    string guessInput = Console.ReadLine();

                    // Make sure the user input for guess is a number
                    if (!int.TryParse(guessInput, out guess))
                    {
                        PrintColourMsg(ConsoleColor.Red, "Error! Please use a number!");
                        // Continue game
                        continue;
                    }

                    // Cast to int  and place in guess variable
                    guess = Int32.Parse(guessInput);

                    // Match guess to correct answer
                    if (guess != correctAnswer)
                    {
                        PrintColourMsg(ConsoleColor.Red, "BZZT Wrong!");
                    }
                }
                // Success Message 
                PrintColourMsg(ConsoleColor.Yellow, "Correct! You got it!");

                // Ask User if they want to play again
                Console.Write("Play Again [Y or N]");
                // Get response and uppercase to ensure Y or N
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else { return; }
            }
        }

        static void GetInfo()
        {
            string appName = "Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Culgan";

            // Change Console Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change Console Text Color back to White
            Console.ResetColor();
        }

        static void StartGame()
        {
            // Ask for user's name
            Console.WriteLine("What is your name?");

            // Put response into a variable
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, care to play a guessing game?", inputName);
        }
        static void PrintColourMsg(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}