using System;

namespace Lab4_TicTacToe.Classes
{
    public class Board
    {
        /// <summary>
        /// Tic Tac Toe Gameboard states
        /// </summary>
        public string[,] GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

        /// <summary>
        /// Output the board to the Console in it's current state
        /// </summary>
        public void DisplayBoard()
        {
            int rows = GameBoard.GetLength(0);
            int columns = GameBoard.GetLength(1); 
            //Output play board to console
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(string.Format("|{0}|", GameBoard[i, j]));
                }
                Console.WriteLine();
            }
        }

    }
}
