using Lab4_TicTacToe.Classes;
using Xunit;
namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindHorizontalWinner()
        {
            //ARRANGE
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;

            // ACT
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";

            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }

        [Fact]
        public void CanFindVerticalWinner()
        {
            //ARRANGE
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;

            // ACT
            board.GameBoard[0, 1] = "O";
            board.GameBoard[0, 2] = "O";

            // Vertical Winner
            board.GameBoard[0, 0] = "X";
            board.GameBoard[1, 1] = "X";
            board.GameBoard[2, 2] = "X";

            board.GameBoard[2, 1] = "O";



            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }
    }
}
