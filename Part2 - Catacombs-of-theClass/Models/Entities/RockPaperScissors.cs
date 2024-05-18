using Part2___Catacombs_of_theClass.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal enum GameOption
    {
        Rock,
        Paper,
        Scissors
    }

    internal class Player
    {
        private string? _name;

        public GameOption? PlayerChoice { get; set; }
        public int Wins { get; set; }

        private static int _playerCount = 0;

        public Player()
        {
            Wins = 0;
        }

        public string? Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrEmpty(value)) _name = $"Player{++_playerCount}";
                else _name = value;
            }
        }
    }

    internal class RockPaperScissors
    {
        private Player? Player1 { get; set; }
        private Player? Player2 { get; set; }
        private Player? Turn { get; set; }
        private static int _tour = 0;

        public RockPaperScissors()
        {
            Player1 = new Player();
            Player2 = new Player();
        }

        public void Init()
        {
            Console.WriteLine("Welcome to the Rock-Paper-Scissors game!");

            bool isGameDone = false;

            while (!isGameDone)
            {
                Console.WriteLine("Play Game? (y/n)");
                if (char.TryParse(Console.ReadLine(), out char playGame) && playGame == 'y')
                {
                    _tour++;
                    if (_tour == 1 || ShouldChangeNames()) EnterNames();

                    try
                    {
                        PlayGame();
                    }
                    catch (Exception ex)
                    {
                        Logger.ExceptionConsole(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Results - {0}", GetResults());
                    isGameDone = true;
                }
            }
        }

        private bool ShouldChangeNames()
        {
            Console.WriteLine("Change player names? (y/n)");
            return char.TryParse(Console.ReadLine(), out char changeNames) && changeNames == 'y';
        }

        private void MakeMoves()
        {
            if (Player1 == null || Player2 == null)
            {
                Console.WriteLine("You need to define players first.");
                EnterNames();
                return;
            }

            if (Turn != null)
            {
                GameOption? playerOption = Utilities.EnumReader.ReadEnum<GameOption>($"{Turn.Name}, make your choice ({Utilities.EnumReader.EnumsToString<GameOption>(", ")}): ");
                Turn.PlayerChoice = playerOption;

                Turn = Turn == Player1 ? Player2 : Player1;
            }
        }

        private void EnterNames()
        {
            Console.WriteLine("Please, enter the players' names");

            Console.Write("Player1: ");
            Player1!.Name = Console.ReadLine();

            Console.Write("Player2: ");
            Player2!.Name = Console.ReadLine();
        }

        private void PlayGame()
        {
            Turn = Player1;

            MakeMoves();
            MakeMoves();

            if (Player1?.PlayerChoice == Player2?.PlayerChoice)
            {
                Console.WriteLine("Draw");
            }
            else if ((Player1?.PlayerChoice == GameOption.Rock && Player2?.PlayerChoice == GameOption.Scissors) ||
                     (Player1?.PlayerChoice == GameOption.Paper && Player2?.PlayerChoice == GameOption.Rock) ||
                     (Player1?.PlayerChoice == GameOption.Scissors && Player2?.PlayerChoice == GameOption.Paper))
            {
                Player1.Wins++;
                Console.WriteLine($"{Player1.Name} won");
            }
            else
            {
                Player2!.Wins++;
                Console.WriteLine($"{Player2.Name} won");
            }
        }

        private string GetResults()
        {
            return $"Tour: {_tour} - {Player1?.Name}: {Player1?.Wins} - {Player2?.Name}: {Player2?.Wins}";
        }
    }
}