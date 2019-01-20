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

        [Fact]
        public void CanSwitchPlayers()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            //assert
            game.SwitchPlayer();
            Assert.True(game.PlayerOne.IsTurn);

            game.SwitchPlayer();
            Assert.True(game.PlayerTwo.IsTurn);
        }

        [Fact]
        public void CorrectIndexWork()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            Position positionOne = Player.PositionForNumber(1);
            Position positionTwo = Player.PositionForNumber(2);

            game.Board.GameBoard[positionOne.Row, positionOne.Column] = playerOne.Marker;
            game.Board.GameBoard[positionTwo.Row, positionTwo.Column] = playerTwo.Marker;

            //assert
            Assert.Equal("X", game.Board.GameBoard[0, 0]);
            Assert.Equal("O", game.Board.GameBoard[0, 1]);
        }

        [Fact]
        public void WinnerXWorks()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard[0, 0] = "X";
            game.Board.GameBoard[1, 0] = "X";
            game.Board.GameBoard[2, 0] = "X";

            //assert
            Assert.True(game.CheckForWinner(game.Board));
        }
    }
}