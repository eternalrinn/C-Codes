using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tesestt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;
            int balance = 0;
            int wins = 0;
            int lose = 0;

            Console.WriteLine("--ROCK PAPER SCISSORS GAME--");
            while (playAgain) 
            {
                player = "";
                computer = "";
                answer = "";
                
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("\tEnter ROCK, PAPER, SCISSORS");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You Win!");
                            balance += 5;
                            wins += 1;
                            Console.WriteLine($"Your new balance is: {balance}$\nWins: {wins}\n:Lose: {lose}");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "PAPER")
                        {
                            lose += 1;
                            Console.WriteLine("You Lose");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                            balance += 5;
                            wins += 1;
                            Console.WriteLine($"Your new balance is: {balance}$\nWins: {wins}\n:Lose: {lose}");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            lose += 1;
                            Console.WriteLine("You Lose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!");
                            balance += 5;
                            wins += 1;
                            Console.WriteLine($"Your new balance is: {balance}$\nWins: {wins}\n:Lose: {lose}");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "ROCK")
                        {
                            lose += 1;
                            Console.WriteLine("You Lose");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? Y or N");
                answer = Console.ReadLine();
                if (answer == "Y".ToLower())
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (answer == "N".ToLower())
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }   

        }
    }
}
