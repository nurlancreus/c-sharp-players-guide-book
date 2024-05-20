using Part2___Catacombs_of_theClass.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Part2___Catacombs_of_theClass.Models.Helpers.Exceptions;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal enum Move
    {
        Up,
        Left,
        Right,
        Down,
        Enter,
    }

    internal class Person
    {
        private static int _count = 0;
        private string _name = string.Empty;
        public char Choice { get; set; }
        public int Id { get; private set; }
        public int CurrentIndex { get; set; } = 0;

        public string? Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value)) _name = $"Person{Id}";
                else _name = value;
            }
        }

        public Person(string name)
        {
            Id = ++_count;
            Name = name;

        }

        public Person() : this(string.Empty)
        {

        }
    }

    internal class Cell
    {
        private static int _count = 0;
        public int Id { get; private set; }
        public char Value { get; private set; }

        public Cell(char ch)
        {
            Id = ++_count;
            Value = ch;
        }

        public void ChangeValue(char value)
        {
            if (Value == '*' || Value == '_') Value = value;
            else if (Value == 'X' || Value == 'Y') return;
            else throw new ArgumentException("The cell already declared");
        }

        public void MoveFrom()
        {
            if (Value == '*') Value = '_';
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }

    internal class GameBoard
    {
        public readonly List<Cell> cells = new(9);

        public GameBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i == 0) cells.Add(new Cell('*'));
                else cells.Add(new Cell('_'));
            }
        }

        public void ShowTable()
        {
            for (int i = 0; i < cells.Count; i++)
            {
                Console.Write(cells[i] + " ");
                if ((i + 1) % 3 == 0) Console.WriteLine();
            }
        }

        public void ClickCell(int index, char ch)
        {
            //if (cells[index] == '_') cells[index] = ch;
            //else throw new ArgumentException("Cell already has value");
            cells[index].ChangeValue(ch);
        }

        public void MakeMovement(int index)
        {
            Cell? activeCell = cells.FirstOrDefault(cell => cell.Value == '*');

            if (activeCell is not null)
            {
                //activeCell.Value = '_';
                activeCell.MoveFrom();
            }

            cells[index].ChangeValue('*');
        }
    }


    internal class TicTacToe
    {
        private int _tour = 0;
        private bool _playGame = false;
        private GameBoard? _board;
        public Person Person1 = new Person();
        public Person Person2 = new Person();
        private Person? _turn;
        public void Init()
        {
            if (!_playGame)
            {
                Console.WriteLine("Would you like to play \"TicTacToe\" game? (y/n)");

                if (char.TryParse(Console.ReadLine()?.ToLower(), out char userChoice) && userChoice == 'y')
                {
                    _playGame = true;
                }
                else
                {
                    Console.WriteLine("You don't want to play the Game");
                    return;
                }
            }

            StartNewGame();
        }

        private void StartNewGame()
        {
            Console.Clear();
            _tour = 0;
            _board = new GameBoard();
            Console.WriteLine("Start New Game");

            Console.Write("Enter \"Person1\"'s name: ");
            string? person1Name = Console.ReadLine();

            Console.Write("Enter \"Person1\"'s name: ");
            string? person2Name = Console.ReadLine();

            Person1.Name = person1Name;
            Person2.Name = person2Name;

            _turn = Person1;

            Console.WriteLine($"{Person1?.Name}, choose:\n" + "1.X\n2.Y");
            int userChoice = (int)Utilities.ProgramUtils.ReadNumber("Your choice: ");

            switch (userChoice)
            {
                case 1:
                    Person1.Choice = 'X';
                    break;
                case 2:
                    Person1.Choice = 'Y';
                    break;
                default:
                    throw new Exception("Choose valid char");
            }

            Person2.Choice = Person1.Choice == 'X' ? 'Y' : 'X';

            while (_playGame)
            {
                PlayGame();
            }
        }

        private void PlayGame()
        {
            _board?.ShowTable();
            Console.WriteLine("You can use arrow keys to move: " +
                "\nArrowUp: Up" +
                "\nArrowLeft: Left" +
                "\nArrowDown: Down" +
                "\nArrowRight: Right");

            try
            {
                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
                    case ConsoleKey.UpArrow:
                        Moves(Move.Up);
                        break;
                    case ConsoleKey.LeftArrow:
                        Moves(Move.Left);
                        break;
                    case ConsoleKey.DownArrow:
                        Moves(Move.Down);
                        break;
                    case ConsoleKey.RightArrow:
                        Moves(Move.Right);
                        break;
                    case ConsoleKey.Enter:
                        ChangeCell();
                        break;
                    default:
                        throw new Exceptions.InvalidKeyException($"Invalid key pressed: {ch}");
                }
            }
            catch (Exceptions.InvalidKeyException ex)
            {
                Console.Clear();
                Logger.ExceptionConsole(ex.Message);
            }
        }

        private void ChangeCell()
        {
            Console.Clear();
            _board.ClickCell(_turn.CurrentIndex, _turn.Choice);
            ChangeTurns();
        }

        private void ChangeTurns()
        {
            _turn = _turn == Person1 ? Person2 : Person1;
        }
        private void Moves(Move moveTo)
        {
            Console.Clear();

            Console.WriteLine(moveTo);

            int index = _turn.CurrentIndex;

            switch (moveTo)
            {
                case Move.Left:
                    MoveLeft(ref index);
                    break;
                case Move.Right:
                    MoveRight(ref index);
                    break;
                case Move.Up:
                    MoveUp(ref index);
                    break;
                case Move.Down:
                    MoveDown(ref index);
                    break;
                default:
                    throw new InvalidKeyException("User cannot move");
            }

            _turn.CurrentIndex = index;
            _board.MakeMovement(_turn.CurrentIndex);
        }

        private void MoveLeft(ref int index)
        {
            if (index == 0 || index == 3 || index == 6)
                index += 2;
            else
            {
                index--;
                if (IsBlocked(index))
                    index--;
            }
        }

        private void MoveRight(ref int index)
        {
            if (index == 2 || index == 5 || index == 8)
                index -= 2;
            else
            {
                index++;
                if (IsBlocked(index))
                    index++;
            }
        }

        private void MoveUp(ref int index)
        {
            if (index == 0 || index == 1 || index == 2)
                index += 6;
            else
            {
                index -= 3;
                if (IsBlocked(index))
                    index -= 3;
            }
        }

        private void MoveDown(ref int index)
        {
            if (index == 6 || index == 7 || index == 8)
                index -= 6;
            else
            {
                index += 3;
                if (IsBlocked(index))
                    index += 3;
            }
        }
        private bool IsBlocked(int index)
        {
            return _board.cells[index].Value == 'X' || _board.cells[index].Value == 'Y';
        }
    }
}
