using System;
using System.Collections.Generic;
using Lab4_TicTacToe.Classes;

namespace Lab4_TicTacToe
{
    class Program
    {
        // program does not handle duplicate locations
        // program does not handle invalid inputs
        static void Main()
        {
            PlayGame();
        }

        /// <summary>
        /// Holds the logic of the activation of the Game
        /// </summary>
        static void PlayGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("Player One, Please enter your name");
            string p1 = Console.ReadLine();

            Player myplayer = new Player
            {
                Name = p1,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine("Player Two, Please enter your name");
            string p2 = Console.ReadLine();

            Player player2 = new Player
            {
                Marker = "O",
                Name = p2,
                IsTurn = false
            };

            Console.Clear();
            Console.WriteLine("Let's start....");

            // Create a new game
            Game game = new Game(myplayer, player2);
			

            Player winner = game.Play();
            if (!(winner is null))
                Console.WriteLine($"{winner.Name} Wins!");
            else
                Console.WriteLine("It's a draw!");
        }
    }
}
