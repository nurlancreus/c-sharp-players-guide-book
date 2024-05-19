using Part2___Catacombs_of_theClass.Models.Entities;
using Part2___Catacombs_of_theClass.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal class Tile(int? num)
    {
        private static int _tileCount = 0;
        public int? data = num;
        public int id = ++_tileCount;

        public bool IsEmpty => data is null;

        public override string ToString()
        {
            return $"{(!IsEmpty ? $"{data}" : "_")}";
        }
    }

    internal class Board
    {
        private readonly Tile[] _table = new Tile[16];

        public Board()
        {
            for (int i = 0; i < Table.Length; i++)
            {
                if (i == Table.Length - 1) Table[i] = new Tile(null);
                else Table[i] = new Tile(i + 1);
            }
        }

        public Tile[] Table
        {
            get => _table;
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < Table.Length; i++)
            {
                Console.Write(Table[i] + " ");
                if ((i + 1) % 4 == 0) Console.WriteLine();
            }
        }

        public void ShuffleBoard()
        {
            Random rand = new();

            for (int i = Table.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (Table[i], Table[j]) = (Table[j], Table[i]);
            }
        }
    }

    internal class Puzzle15Game
    {
        public Board? Board;
        private int _tour = 0;
        private bool _playGame = false;

        public void Init()
        {
            Console.WriteLine("Would you like to play \"Puzzle 15\" game? (y/n)");
            if (char.TryParse(Console.ReadLine(), out char userAnswer) && userAnswer == 'y')
            {
                _tour = 0;
                _playGame = true;
                Board = new Board();
                Board.ShuffleBoard();

                while (_playGame)
                {
                    _tour++;
                    PlayGame();
                }
            }
            else
            {
                Console.WriteLine("You don't want to play game.");
            }
        }

        private void PlayGame()
        {
            Console.WriteLine("Board:");
            Board?.DisplayBoard();

            Console.WriteLine("\nYou should arrange cells to be in order.\n");
            Console.WriteLine("1. Up.\n2. Left.\n3. Down.\n4. Right.\n5. Show Board.\n0. Exit Game.");
            int userChoice = (int)Utilities.ProgramUtils.ReadNumber("Your choice: ");


            try
            {
                switch (userChoice)
                {
                    case 1:
                        MoveCells("up");
                        break;
                    case 2:
                        MoveCells("left");
                        break;
                    case 3:
                        MoveCells("down");
                        break;
                    case 4:
                        MoveCells("right");
                        break;
                    case 5:
                        Board?.DisplayBoard();
                        break;
                    case 0:
                        _playGame = false;
                        Console.WriteLine("You exited the Game");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.ExceptionConsole(ex.Message);
            }

        }

        private void MoveCells(string side)
        {
            if (Board != null)
            {
                Console.Clear();
                int emptyCellIndex = -1;

                foreach (var tile in Board.Table)
                {
                    if (tile.IsEmpty)
                    {
                        emptyCellIndex = Array.IndexOf(Board.Table, tile);
                        break;
                    }
                }

                if (emptyCellIndex == -1) throw new Exception("Empty cell not found");

                int possibleCellIndex = -1;

                switch (side.ToLower())
                {
                    case "left":
                        if (emptyCellIndex % 4 != 0)
                        {
                            possibleCellIndex = emptyCellIndex - 1;
                        }
                        break;

                    case "right":
                        if (emptyCellIndex % 4 != 3)
                        {
                            possibleCellIndex = emptyCellIndex + 1;
                        }
                        break;

                    case "up":
                        if (emptyCellIndex > 3)
                        {
                            possibleCellIndex = emptyCellIndex - 4;
                        }
                        break;

                    case "down":
                        if (emptyCellIndex < 12)
                        {
                            possibleCellIndex = emptyCellIndex + 4;
                        }
                        break;

                    default:
                        throw new Exception("Invalid move direction");
                }

                if (possibleCellIndex != -1)
                {
                    Logger.SuccessConsole($"Empty cell moves to {side}");
                    (Board.Table[emptyCellIndex], Board.Table[possibleCellIndex]) = (Board.Table[possibleCellIndex], Board.Table[emptyCellIndex]);
                    CheckWinCondition();
                }
                else
                {
                    throw new Exception("You cannot go outside of the board");
                }
            }
            else
            {
                throw new Exception("Board is not initialized yet. Please first init the game");
            }
        }

        private void CheckWinCondition()
        {
            bool allIsInOrder = true;

            for (int i = 0; i < Board?.Table.Length - 1; i++)
            {
                if (Board?.Table[i].id != i + 1)
                {
                    allIsInOrder = false;
                    break;
                }
            }

            if (allIsInOrder)
            {
                Logger.SuccessConsole($"Congratulations! You won the game! (Attempts: {_tour})");
                _playGame = false;
            }
        }
    }
}

