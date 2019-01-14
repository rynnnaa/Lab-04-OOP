using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game");

            Player p1 = new Player();
            Player p2 = new Player();

            p1.Marker = "O";
            p2.Marker = "X";


            Board newBoard = new Board();
            newBoard.DisplayBoard();

            Game game = new Game(p1, p2);
            game.Play();
        }

    }
}
