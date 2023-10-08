using System;

// Namespace
namespace NumberGuesser
{
    class Program
    {

        // Entry Point Method
        static void Main(string[] args)

        {
            // Run GetAppInfo function to get info 
            GettAppInfo();

            // Greet for username and greet
            GreetUser();

            // Set correct number
            //int correctNumber = 7;

            // create a new ramdom object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            while (true)
            {

                // Init guess var
                int guess = 0;


                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10!");

                // While guess is not equal to correct number
                while (guess != correctNumber)
                {
                    // Get user input
                    string userInput = Console.ReadLine();

                    //make sure it´s a number
                    if (!int.TryParse(userInput, out guess))
                    {
                        

                        PrintColorMessage(ConsoleColor.Red, "Pleace use an actual number!");

                        //keep going
                        continue;

                    }

                    // Cast to int and put in guess  "Wrong number, pleace try again"
                    guess = Int32.Parse(userInput);
                    
                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, pleace try again");

                       
                    }
                }

                // Output sussess message

                // Change text color with function
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!, the number was" +   " " + correctNumber);

                // Ask to play again
                Console.WriteLine("Play again? [Y/N]:");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
                }


            }

        // Get and desplay app info
        static void GettAppInfo()
        {
            // Sett app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Daniel John Russell";

            // Change text color

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // Write out app info
            Console.WriteLine("{0}: Verson {1} by {2}", appName, appVersion, appAuthor);

            // Reset Color
            Console.ResetColor();
        }

        // Ask user name and greet
        static void GreetUser()
        {
            // Ask users name

            Console.WriteLine("What it your name ?");

            // Get user input

            string userInputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let´s play a game!", userInputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string massage)
        {
            Console.ForegroundColor = color;

            // Tell user its wronggggg!
            Console.WriteLine(massage);

            // Reset Color
            Console.ResetColor();

        }

    }
    }
