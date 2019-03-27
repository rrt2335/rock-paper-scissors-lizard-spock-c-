using System;

namespace rpsls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game description and instructions
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("Type in either 'rock', 'paper', 'scissors', 'lizard' or 'spock' as your choice.");
            Console.WriteLine("The computer will make a choice randomly and the game will be decided.");
            Console.WriteLine("Which will you choose?");
            Console.WriteLine("(1)Rock (2)Paper (3)Scissors (4)Lizard (5)Spock (Please select a number.)");

            // Input choice
            Random mathRandomTool = new Random();
            int playerChoice;
            string choice = Console.ReadLine();
            bool playing = true;
            bool valid = false;
            while (!valid)
            {
                if (Int32.TryParse(choice, out playerChoice))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please provide a valid number.");
                    choice = Console.ReadLine();
                }
                while (playing)
                {
                    if (playerChoice >= 1 && playerChoice <= 5)
                    {
                        if (playerChoice == 1)
                        {
                            Console.WriteLine("You have chosen rock.");
                        }
                        if (playerChoice == 2)
                        {
                            Console.WriteLine("You have chosen paper.");
                        }
                        if (playerChoice == 3)
                        {
                            Console.WriteLine("You have chosen scissors.");
                        }
                        if (playerChoice == 4)
                        {
                            Console.WriteLine("You have chosen lizard.");
                        }
                        if (playerChoice == 5)
                        {
                            Console.WriteLine("You have chosen spock.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please provide a number between 1 to 5.");
                        valid = false;
                        choice = Console.ReadLine();
                    }

                }

                int computerChoice = mathRandomTool.Next(1, 5);
                Console.WriteLine("The computer has chosen " + computerChoice + ".");

                if (playerChoice == 1 && computerChoice == 3)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 1 && computerChoice == 2)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 1 && computerChoice == 4)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 1 && computerChoice == 5)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 2 && computerChoice == 1)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 2 && computerChoice == 3)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 2 && computerChoice == 4)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 2 && computerChoice == 5)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 3 && computerChoice == 2)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 3 && computerChoice == 1)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 3 && computerChoice == 4)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 3 && computerChoice == 5)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 4 && computerChoice == 2)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 4 && computerChoice == 1)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 4 && computerChoice == 3)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 4 && computerChoice == 5)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 5 && computerChoice == 2)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 5 && computerChoice == 1)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == 5 && computerChoice == 4)
                {
                    Console.WriteLine("You lose.");
                }
                else if (playerChoice == 5 && computerChoice == 3)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("It's a draw.");
                }
                playing = false;

            }
        }
    }
}
