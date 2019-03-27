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
            string choice = Console.ReadLine();
            int playerChoice;
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
            Console.WriteLine("This is the outcome of the game.");


            // if (playerChoice == 1)
            // {
            //     decided = true;
            //     Console.WriteLine("You have chosen rock.");
            // }


            // Console.WriteLine("The computer has chosen " + comNumber + ".");

            // if (playerChoice == computerChoice)
            // {
            //     drawCount++;
            //     return "IT'S A DRAW.";
            // }
            // else if (playerChoice == "ROCK" && computerChoice == "SCISSORS")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "ROCK" && computerChoice == "PAPER")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "ROCK" && computerChoice == "LIZARD")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "ROCK" && computerChoice == "SPOCK")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "PAPER" && computerChoice == "ROCK")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "PAPER" && computerChoice == "SCISSORS")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "PAPER" && computerChoice == "LIZARD")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "PAPER" && computerChoice == "SPOCK")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "SCISSORS" && computerChoice == "PAPER")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "SCISSORS" && computerChoice == "ROCK")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "SCISSORS" && computerChoice == "LIZARD")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "SCISSORS" && computerChoice == "SPOCK")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "LIZARD" && computerChoice == "PAPER")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "LIZARD" && computerChoice == "ROCK")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "LIZARD" && computerChoice == "SCISSORS")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "LIZARD" && computerChoice == "SPOCK")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "SPOCK" && computerChoice == "PAPER")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "SPOCK" && computerChoice == "ROCK")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }
            // else if (playerChoice == "SPOCK" && computerChoice == "LIZARD")
            // {
            //     lossCount++;
            //     return "YOU LOSE...";
            // }
            // else if (playerChoice == "SPOCK" && computerChoice == "SCISSORS")
            // {
            //     winCount++;
            //     return "YOU WIN!";
            // }

        }
    }
}
