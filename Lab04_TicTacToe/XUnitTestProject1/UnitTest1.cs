using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe.Classes.Lab04_TicTacToe.Classes;
using Xunit;

namespace Lab40104xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void WinnerOWorks()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[1, 0] = "O";
            game.Board.GameBoard[2, 0] = "O";

            //assert
            Assert.True(game.CheckForWinner(game.Board));
        }

    }
}