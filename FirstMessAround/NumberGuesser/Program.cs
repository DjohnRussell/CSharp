using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        private static object Int33;

        // Entry Point Method
        static void Main(string[] args)
        {

            // Start here //

            string name = "Daniel John Russell";
            int age = 33;
            string job = "Student, not working";

            Console.WriteLine(name + " is " + age);

            //Other way of concatenate strings...
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("{0} is {1}", name, age);
            Console.WriteLine("{0} is {1}, and is currantly {2}", name, age, job);

            Console.ResetColor();

            Console.WriteLine("Testing");

            int number = 20;
            Console.WriteLine("Guess the number: ");
            string input = Console.ReadLine();
            int intInput = Int32.Parse(input);



        {

        }




            
            
                if (intInput != 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not right");
                }
                else if (intInput == 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yeah u got it!");
                }
            }

        }
    }
