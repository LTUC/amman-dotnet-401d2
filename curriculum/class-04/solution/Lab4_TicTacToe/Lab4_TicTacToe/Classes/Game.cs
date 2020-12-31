using System;

namespace Lab4_TicTacToe.Classes
{
    public class Game
    {
        // Every game has 2 players and a board. 
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player Winner { get; set; }
        public Board Board { get; set; }


        /// <summary>
        /// Require 2 players and a board to start a game. 
        /// </summary>
        /// <param name="p1">Player 1</param>
        /// <param name="p2">Player 2</param>
        public Game(Player p1, Player p2)
        {
            PlayerOne = p1;
            PlayerTwo = p2;
            Board = new Board();
        }

        /// <summary>
        /// Activate the Play of the game
        /// </summary>
        /// <returns>Winner</returns>
        public Player Play()
        {
            int counter = 0;
            //While there is not a winner, keep playing the game.
            while (!CheckForWinner(Board) && counter < 9)
            {
                Console.WriteLine($"{PlayerOne.Name} is {PlayerOne.Marker}'s");
                Console.WriteLine($"{PlayerTwo.Name} is {PlayerTwo.Marker}'s");

                Board.DisplayBoard();
                Player player = NextPlayer();

                player.TakeTurn(Board);
                SwitchPlayer();

                Console.Clear();
                counter++;
            }

            Board.DisplayBoard();
            
            return Winner;
        }

        /// <summary>
        /// Check if winner exists
        /// </summary>
        /// <param name="board">current state of the board</param>
        /// <returns>if winner exists</returns>
        public bool CheckForWinner(Board board)
        {
            int[][] winners = new int[][]
            {
                new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},

                new[] {1,4,7},
                new[] {2,5,8},
                new[] {3,6,9},

                new[] {1,5,9},
                new[] {3,5,7}
            };

            for (int i = 0; i < winners.Length; i++)
            {
                Position p1 = Player.PositionForNumber(winners[i][0]);
                Position p2 = Player.PositionForNumber(winners[i][1]);
                Position p3 = Player.PositionForNumber(winners[i][2]);

                string a = Board.GameBoard[p1.Row, p1.Column];
                string b = Board.GameBoard[p2.Row, p2.Column];
                string c = Board.GameBoard[p3.Row, p3.Column];

                if ((a == b) && (b == c))
                {
                    Winner = (a == "X" ? PlayerOne : PlayerTwo);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determine next player
        /// </summary>
        /// <returns>next player</returns>
        public Player NextPlayer()
        {
            return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
        }

        /// <summary>
        /// End one players turn and activeate the other
        /// </summary>
        public void SwitchPlayer()
        {
            if (PlayerOne.IsTurn)
            {
                PlayerOne.IsTurn = false;
                PlayerTwo.IsTurn = true;
            }
            else
            {
                PlayerOne.IsTurn = true;
                PlayerTwo.IsTurn = false;
            }
        }
    }
}
