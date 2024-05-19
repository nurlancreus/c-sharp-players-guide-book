using Part2___Catacombs_of_theClass.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal class Word
    {
        private string _data = string.Empty;
        private readonly List<char> _placeHolders;
        private readonly List<char> _incorrectGuesses;

        public Word(string word)
        {
            Data = word.ToUpper();
            _placeHolders = new List<char>(new string('_', Data.Length));
            _incorrectGuesses = [];
        }

        public string Data
        {
            get => _data;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Provide valid data");
                _data = value;
            }
        }

        public void Guess(char ch)
        {
            ch = char.ToUpper(ch);

            if (_placeHolders.Contains(ch))
            {
                Console.WriteLine("Character is already revealed. Try different one.");
            }
            else
            {
                if (Data.Contains(ch))
                {
                    for (int i = 0; i < Data.Length; i++)
                    {
                        if (Data[i] == ch)
                            _placeHolders[i] = ch;
                    }
                }
                else
                {
                    _incorrectGuesses.Add(ch);
                }
            }
        }

        public List<char> GetIncorrectGuesses() => _incorrectGuesses;

        public int GetRemainingCharsCount() => _placeHolders.Count(ch => ch == '_');

        public override string ToString() => string.Join(" ", _placeHolders);
    }

    internal class Hangman
    {
        private byte _tour;
        private bool _playGame;
        private Word? _word;
        private readonly string[] _words = ["apple", "banana", "grapefruit", "kiwi", "mango"];

        public void Init()
        {
            if (!_playGame)
            {
                Console.WriteLine("Would you like to play \"Hangman\" game? (y/n)");
                if (char.TryParse(Console.ReadLine(), out char userAnswer) && userAnswer == 'y')
                {
                    _playGame = true;
                }
                else
                {
                    Console.WriteLine("You don't want to play game.");
                    return;
                }
            }

            StartNewGame();
        }

        private void StartNewGame()
        {
            Console.Clear();
            _tour = 0;
            _word = new Word(GetRandomWord());

            if (_word is not null)
            {
                while (_playGame)
                {
                    _tour++;
                    PlayGame();
                }
            }
            else Console.WriteLine("The word is not initialized, please init the game first.");
        }

        private void PlayGame()
        {
            char userGuess = Utilities.ProgramUtils.ReadChar($"Word: {_word} | Remaining: {_word!.GetRemainingCharsCount()} | Incorrect: {string.Join(", ", _word.GetIncorrectGuesses())} | Guess: ");
            _word.Guess(userGuess);

            CheckWinCondition();
        }

        private void CheckWinCondition()
        {
            if (_word!.GetRemainingCharsCount() == 0)
            {
                Logger.SuccessConsole($"Congratulations! You won the game (in {_tour} attempts)!\nWord: {_word}");
                AskToPlayAgain();
            }
            else if (_word.GetIncorrectGuesses().Count > _word.Data.Length)
            {
                Logger.ExceptionConsole($"YOU LOST! The word was {_word.Data}");
                AskToPlayAgain();
            }
        }

        private void AskToPlayAgain()
        {
            Console.Write("Try Again(y/n): ");
            if (char.TryParse(Console.ReadLine(), out char userChoice) && userChoice == 'y')
            {
                StartNewGame();
            }
            else
            {
                _playGame = false;
            }
        }

        private string GetRandomWord()
        {
            Random rand = new Random();
            return _words[rand.Next(_words.Length)];
        }

    }
}
