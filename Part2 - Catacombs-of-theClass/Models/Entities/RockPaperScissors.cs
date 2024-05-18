using Part2___Catacombs_of_theClass.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    /// <summary>
    /// Enum representing the possible options in the Rock-Paper-Scissors game.
    /// </summary>
    internal enum GameOption
    {
        Rock,
        Paper,
        Scissors
    }

    /// <summary>
    /// Represents a player in the Rock-Paper-Scissors game.
    /// </summary>
    internal class Player
    {
        private string? _name;

        /// <summary>
        /// Gets or sets the player's choice of game option.
        /// </summary>
        public GameOption? PlayerChoice { get; set; }

        /// <summary>
        /// Gets or sets the number of wins the player has.
        /// </summary>
        public int Wins { get; set; }

        private static int _playerCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player()
        {
            Wins = 0;
        }

        /// <summary>
        /// Gets or sets the name of the player. If the name is null or empty, it assigns a default name.
        /// </summary>
        public string? Name
        {
            get => _name;
            set => _name = string.IsNullOrEmpty(value) ? $"Player{++_playerCount}" : value;
        }
    }

    /// <summary>
    /// Manages the Rock-Paper-Scissors game, including players, turns, and game logic.
    /// </summary>
    internal class RockPaperScissors
    {
        private Player? Player1 { get; set; }
        private Player? Player2 { get; set; }
        private Player? Turn { get; set; }
        private static int _tour = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="RockPaperScissors"/> class and creates two players.
        /// </summary>
        public RockPaperScissors()
        {
            Player1 = new Player();
            Player2 = new Player();
        }

        /// <summary>
        /// Starts the game, prompting the user to play or end the game, and handles the game loop.
        /// </summary>
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

        /// <summary>
        /// Prompts the user to change player names.
        /// </summary>
        /// <returns>True if the player names should be changed; otherwise, false.</returns>
        private bool ShouldChangeNames()
        {
            Console.WriteLine("Change player names? (y/n)");
            return char.TryParse(Console.ReadLine(), out char changeNames) && changeNames == 'y';
        }

        /// <summary>
        /// Prompts the current player to make a move.
        /// </summary>
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

        /// <summary>
        /// Prompts the user to enter the names of the players.
        /// </summary>
        private void EnterNames()
        {
            Console.WriteLine("Please, enter the players' names");

            Console.Write("Player1: ");
            Player1!.Name = Console.ReadLine();

            Console.Write("Player2: ");
            Player2!.Name = Console.ReadLine();
        }

        /// <summary>
        /// Executes the game logic, determining the winner based on player choices.
        /// </summary>
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

        /// <summary>
        /// Gets the results of the game, including the number of tours and the number of wins for each player.
        /// </summary>
        /// <returns>A string representing the game results.</returns>
        private string GetResults()
        {
            return $"Tour: {_tour} - {Player1?.Name}: {Player1?.Wins} - {Player2?.Name}: {Player2?.Wins}";
        }
    }
}