using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    //class Darius
    //{
    //    public string name = "Darius";
    //    public string alias = "Dragon";
    //    public int age = 24;
    //}

    class Program
    {
        static void Main(string[] args)
        {
            // preserve current console text color
            ConsoleColor oldcolor = Console.ForegroundColor;

            TellWhatProgramIs();

            //Creating a random number generator
            Random randomizer = new Random();

            Console.WriteLine("Type in 'quit' to exit at any time");

            //Loop infinitely   
            while (true)
            {
                Console.WriteLine();
                string question = GetQuestion();

                // Timer to give the computer the illusion of thinking
                int numberOfSecondsToSleep = randomizer.Next(5) + 1;
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                // creating a break in the loop
                if (question.ToLower() == "quit")
                {
                    break;
                }

                if (question.Length == 0)
                {
                    Console.WriteLine("You need to type a question!!!!");
                    continue;
                }
                // Get a random number
                int randomNumber = randomizer.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomizer.Next(14);

                // USE RANDOM NUMBER TO DETERMINE RESPONSE
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }

                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("HELL YES!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("HELL NO!");
                            break;
                        }

                    default:
                        break;

                }

            }

            //Cleaning up = restoring console color
            Console.ForegroundColor = oldcolor;
        }
        
        // Method tto tell people the name of the program
        static void TellWhatProgramIs()
        {
            //Change Console text color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("agic 8 Ball App");
        }

        //This function will return the text that the user types.
        static string GetQuestion()
        {
            //This block of code will ask a question and store the answer
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string question = Console.ReadLine();

            return question;
        }
    }
}
