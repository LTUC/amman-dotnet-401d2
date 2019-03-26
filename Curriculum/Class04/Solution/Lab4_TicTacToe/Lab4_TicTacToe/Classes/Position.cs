namespace Lab4_TicTacToe.Classes
{
   public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        /// <summary>
        /// Position on the gameboard being initialized 
        /// </summary>
        /// <param name="row">row number</param>
        /// <param name="column">column number</param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
