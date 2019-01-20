﻿using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe.Classes.Lab04_TicTacToe.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {   //gets and sets the name of players
        public string Name { get; set; }

        /// <summary>
        /// P1 is X and P2 will be O
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Flag to determine if it is the user's turn
        /// </summary>
        public bool IsTurn { get; set; }

        /// <summary>
        /// Prompts the player to choose a position on the board
        /// </summary>
        /// <param name="board"></param>
        /// <returns>returns the position the player chooses</returns>
		public Position GetPosition(Board board)
        {
            Position desiredCoordinate = null;
            while (desiredCoordinate is null)
            {
                Console.WriteLine("Please select a location");
                Int32.TryParse(Console.ReadLine(), out int position);
                desiredCoordinate = PositionForNumber(position);
            }
            return desiredCoordinate;
        }

        /// <summary>
        /// This represents the possible positions
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
		public static Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0); // Top Left
                case 2: return new Position(0, 1); // Top Middle
                case 3: return new Position(0, 2); // Top Right
                case 4: return new Position(1, 0); // Middle Left
                case 5: return new Position(1, 1); // Middle Middle
                case 6: return new Position(1, 2); // Middle Right
                case 7: return new Position(2, 0); // Bottom Left
                case 8: return new Position(2, 1); // Bottom Middle
                case 9: return new Position(2, 2); // Bottom Right

                default: return null;
            }
        }

        /// <summary>
        /// This tell the player when it is their turn and marks the position they choose
        /// </summary>
        /// <param name="board"></param>
        public void TakeTurn(Board board)
        {
            IsTurn = true;

            Console.WriteLine($"{Name} it is your turn");

            bool playerPosition;

            do
            {
                Position position = GetPosition(board);

                if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
                {
                    board.GameBoard[position.Row, position.Column] = Marker;
                    playerPosition = false;
                }
                else
                {
                    Console.WriteLine("This space is already occupied");
                    playerPosition = true;
                }
            } while (playerPosition == true);
        }
    }
}