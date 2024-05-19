using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using Part2___Catacombs_of_theClass.Models.Entities;
using Point = Part2___Catacombs_of_theClass.Models.Entities.Point;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Threading;
using System;
using Color = Part2___Catacombs_of_theClass.Models.Entities.Color;
using Part2___Catacombs_of_theClass.Models.Helpers;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection;
using Microsoft.VisualBasic.FileIO;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Timers;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Buffers.Text;
using System.Collections;
using System.Diagnostics;

namespace Part2___Catacombs_of_theClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region - Challenge1
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge1************");
            Console.WriteLine("*********************************");

            //            Boss Battle The Point 75 XP
            //The first pedestal asks you to create a Point class to store a point in two dimensions.Each point is
            //represented by an x-coordinate (x), a side-to-side distance from a special central point called the origin,
            //and a y-coordinate (y), an up-and-down distance away from the origin.
            //Objectives:
            //• Define a new Point class with properties for X and Y.
            //• Add a constructor to create a point from a specific x- and y-coordinate.
            //• Add a parameterless constructor to create a point at the origin(0, 0).
            //• In your main method, create a point at(2, 3) and another at(-4, 0). Display these points on the
            //console window in the format(x, y) to illustrate that the class works.
            //• Answer this question: Are your X and Y properties immutable? Why did you choose what you did?

            Point point1 = new Point(0, 0);
            Point point2 = new Point(2, 3);
            Point point3 = new Point(-4, 0);

            static void ShowPointCoords(string name, in Point point)
            {
                Console.WriteLine($"{name}: ({point.X}, {point.Y})");
            }

            ShowPointCoords(nameof(point1), point1);
            ShowPointCoords(nameof(point2), point2);
            ShowPointCoords(nameof(point3), point3);

            //point3.X = 7;
            Console.WriteLine("We cannot set new coords to the point, i made its properties readonly");


            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;

            #region - Challenge2
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge2************");
            Console.WriteLine("*********************************");

            //            Boss Battle The Color 100 XP
            //The second pedestal asks you to create a Color class to represent a color.The pedestal includes an
            //etching of this diagram that illustrates its potential usage:
            //The color consists of three parts or channels: red, green, and blue, which indicate how much those
            //channels are lit up.Each channel can be from 0 to 255. 0 means completely off; 255 means completely
            //on.
            //The pedestal also includes some color names, with a set of numbers indicating their specific values for
            //each channel.These are commonly used colors: White (255, 255, 255), Black(0, 0, 0), Red(255, 0, 0),
            //Orange(255,165, 0), Yellow(255, 255, 0), Green(0, 128, 0), Blue(0, 0, 255), Purple(128, 0, 128).
            //Objectives:
            //• Define a new Color class with properties for its red, green, and blue channels.
            //• Add appropriate constructors that you feel make sense for creating new Color objects.
            //• Create static properties to define the eight commonly used colors for easy access.
            //• In your main method, make two Color-typed variables. Use a constructor to create a color instance
            //and use a static property for the other.Display each of their red, green, and blue channel values.

            bool isOperationsDone = false;

            //static void Utilities.Colors.MakeColor(Color? userColor,  string color)
            //{
            //    Console.WriteLine($"You choose {color} color.");
            //    userColor = Color.MakeBlack();
            //    Console.WriteLine($"Color: {userColor?.ReadColor()}");
            //}

            while (!isOperationsDone)
            {
                Console.WriteLine("You either choose to create custom color or make one of most used ones.");
                Console.WriteLine("" +
                    "1.For custom Color." +
                    "\n2.For White." +
                    "\n3.For Black." +
                    "\n4.For Red." +
                    "\n5.For Orange." +
                    "\n6.For Yellow." +
                    "\n7.For Green." +
                    "\n8.For Blue." +
                    "\n9.For Purple color." +
                    "\n0.For exit.");
                Console.WriteLine("Choose one of them.");
                Color? userColor = null;

                if (byte.TryParse(Console.ReadLine(), out byte userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Choose your RGB colors.");
                            Console.Write("Red: ");
                            bool isUserChooseRed = byte.TryParse(Console.ReadLine(), out byte userRed);
                            Console.Write("Green: ");
                            bool isUserChooseGreen = byte.TryParse(Console.ReadLine(), out byte userGreen);
                            Console.Write("Blue: ");
                            bool isUserChooseBlue = byte.TryParse(Console.ReadLine(), out byte userBlue);

                            if (isUserChooseRed && isUserChooseGreen && isUserChooseBlue)
                            {
                                userColor = new Color(userRed, userGreen, userBlue);
                            }
                            else
                            {
                                Utilities.ProgramUtils.ExitProgram(ref isOperationsDone, "values");

                            }
                            break;

                        case 2:
                            userColor = Utilities.Colors.MakeColor("White");
                            break;
                        case 3:
                            userColor = Utilities.Colors.MakeColor("Black");
                            break;
                        case 4:
                            userColor = Utilities.Colors.MakeColor("Red");
                            break;
                        case 5:
                            userColor = Utilities.Colors.MakeColor("Orange");
                            break;
                        case 6:
                            userColor = Utilities.Colors.MakeColor("Yellow");
                            break;
                        case 7:
                            userColor = Utilities.Colors.MakeColor("Green");
                            break;
                        case 8:
                            userColor = Utilities.Colors.MakeColor("Blue");
                            break;
                        case 9:
                            userColor = Utilities.Colors.MakeColor("Purple");
                            break;
                        case 0:
                        default:

                            Utilities.ProgramUtils.ExitProgram(ref isOperationsDone);
                            break;
                    }

                    Console.WriteLine($"Your color is {userColor}.");

                }
                else
                {
                    Utilities.ProgramUtils.ExitProgram(ref isOperationsDone);

                };
            }

            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;

            #region - Challenge3
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge3************");
            Console.WriteLine("*********************************");

            //            Boss Battle The Card 100 XP
            //The digital Realms of C# have playing cards like ours but with some differences. Each card has a color
            //(red, green, blue, yellow) and a rank(the numbers 1 through 10, followed by the symbols $, %, ^, and &).
            //The third pedestal requires that you create a class to represent a card of this nature.
            //192 LEVEL 24 THE CATACOMBS OF THE CLASS
            //Objectives:
            //• Define enumerations for card colors and card ranks.
            //• Define a Card class to represent a card with a color and a rank, as described above.
            //• Add properties or methods that tell you if a card is a number or symbol card (the equivalent of a
            //face card).
            //• Create a main method that will create a card instance for the whole deck(every color with every
            //rank) and display each(for example, “The Red Ampersand” and “The Blue Seven”).
            //• Answer this question: Why do you think we used a color enumeration here but made a color class
            //in the previous challenge?

            try
            {

                //Console.WriteLine("Define a card with color, ranks or symbols");
                //CardColor? cardColor = Utilities.EnumReader.ReadEnum<CardColor>("Enter the Card Color: ");
                //CardRank? cardRank = Utilities.EnumReader.ReadEnum<CardRank>("Enter the Card Rank: ");
                //CardSymbol? cardSymbol = Utilities.EnumReader.ReadEnum<CardSymbol>("Enter the Card Symbol: ");

                //Card card = new Card();

                CardColor[] cardColors = (CardColor[])Enum.GetValues(typeof(CardColor));
                CardRank[] cardRanks = (CardRank[])Enum.GetValues(typeof(CardRank));

                List<Card> cards = [];

                foreach (var color in cardColors)
                {
                    foreach (var rank in cardRanks)
                    {
                        Card card = new(color, rank);
                        cards.Add(card);
                    }
                }

                Console.WriteLine("Here is each card in the list");
                cards.ForEach(Console.WriteLine);

            }
            catch (Exception ex)
            {
                Logger.ExceptionConsole(ex.Message);
            }

            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;

            #region - Challenge4
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge4************");
            Console.WriteLine("*********************************");

            //            Boss Battle The Locked Door 100 XP
            //The fourth pedestal demands constructing a door class with a locking mechanism that requires a unique
            //numeric code to unlock.You have done something similar before without using a class, but the locking
            //mechanism is new. The door should only unlock if the passcode is the right one.The following statements
            //describe how the door works.
            //• An open door can always be closed.
            //• A closed (but not locked) door can always be opened.
            //• A closed door can always be locked.
            //• A locked door can be unlocked, but a numeric passcode is needed, and the door will only unlock if
            //the code supplied matches the door’s current passcode.
            //• When a door is created, it must be given an initial passcode.
            //• Additionally, you should be able to change the passcode by supplying the current code and a new
            //one.The passcode should only change if the correct, current code is given.
            //Objectives:
            //• Define a Door class that can keep track of whether it is locked, open, or closed.
            //• Make it so you can perform the four transitions defined above with methods.
            //• Build a constructor that requires the starting numeric passcode.
            //• Build a method that will allow you to change the passcode for an existing door by supplying the
            //current passcode and new passcode.Only change the passcode if the current passcode is correct.
            //• Make your main method ask the user for a starting passcode, then create a new Door instance.Allow
            //the user to attempt the four transitions described above (open, close, lock, unlock) and change the
            //code by typing in text commands.

            bool isDoorOperationsDone = false;
            Door door = new Door();
            while (!isDoorOperationsDone)
            {
                Console.WriteLine("1. Open the door.\n"
                    + "2. Close the door.\n"
                    + "3. Lock the door.\n"
                    + "4. Unlock the door.\n"
                    + "5. Change the password.\n"
                    + "6. Exit."
                    );

                if (int.TryParse(Console.ReadLine(), out int userChoice))
                {

                    switch (userChoice)
                    {
                        case 1:
                            door.ChangeDoorState("open");
                            break;
                        case 2:
                            door.ChangeDoorState("close");
                            break;
                        case 3:
                            door.ChangeDoorState("lock");
                            break;
                        case 4:
                            door.ChangeDoorState("unlock");
                            break;
                        case 5:
                            Console.WriteLine("You want to change the password.\nPlease, provide current password and the new one");

                            if (int.TryParse(Console.ReadLine(), out int currentPw) && int.TryParse(Console.ReadLine(), out int newPw))
                            {
                                door.ChangePassword(currentPw, newPw);
                            }
                            else Console.WriteLine("Your data is invalid. Please, Input valid passwords");

                            break;

                        case 6:
                            isDoorOperationsDone = true;

                            break;

                        default:
                            Utilities.ProgramUtils.ExitProgram(ref isDoorOperationsDone, "input");
                            break;

                    }

                }
                else Utilities.ProgramUtils.ExitProgram(ref isDoorOperationsDone);

            }


            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;
           

            #region - Challenge5
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge5************");
            Console.WriteLine("*********************************");
            //            Boss Battle The Password Validator 100 XP
            //The fifth and final pedestal describes a class that represents a concept more abstract than the first four:
            //a password validator.You must create a class that can determine if a password is valid(meets the rules
            //defined for a legitimate password). The pedestal initially doesn’t describe any rules, but as you brush the
            //dust off the pedestal, it vibrates for a moment, and the following rules appear:
            //• Passwords must be at least 6 letters long and no more than 13 letters long.
            //• Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
            //OBJECT-ORIENTED DESIGN 193
            //• Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.
            //That last rule seems random, and you wonder if the pedestal is just tormenting you with obscure rules.
            //You ponder for a moment about how to decide if a character is uppercase, lowercase, or a number, but
            //while scratching your head, you notice a piece of folded parchment on the ground near your feet.You
            //pick it up, unfold it, and read it:
            //foreach with a string lets you get its characters!
            //> foreach (char letter in word)
            //        { ... }
            //        char has static methods to categorize letters!
            //> char.IsUpper('A'), char.IsLower('a'), char.IsDigit('0')
            //That might be useful information! You are grateful to whoever left it behind.It is signed simply “A.”
            //Objectives:
            //• Define a new PasswordValidator class that can be given a password and determine if the
            //password follows the rules above.
            //• Make your main method loop forever, asking for a password and reporting whether the password is
            //allowed using an instance of the PasswordValidator class.

            while (true)
            {
                Console.Write("Enter the password: ");
                string? pw = Console.ReadLine();

                if (pw is null) break;

                if (PasswordValidator.IsPasswordValid(pw)) Console.WriteLine("Password is valid");
                else Console.WriteLine("Password is not valid");

            }

            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;


            #region - Challenge6
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge6************");
            Console.WriteLine("*********************************");

            //            Narrative The Chamber of Design
            //As you finish the final class and place its complete definition back on its pedestal, the writing on each
            //pedestal begins to glow a reddish-orange.A beam forms from each pedestal, extending upward towards
            //the high cavernous ceiling.Additional runes on the wall begin to shine as well, and the far walls slide
            //apart, revealing an opening further into the Catacombs.
            //You pass through to the next chamber and find three more pedestals with etched text.On the floor, in
            //a ring running around the three pedestals, lie the words, “Only a True Programmer can design a system
            //of objects for the ancient games of the people.”
            //You must make an object-oriented design (not a complete program) for each game described on the
            //three pedestals in the room’s center to continue further.
            //The following three challenges will help you practice object-oriented design.You do not need
            //to make the full game! You only need a starting point in the form of CRC cards (or a suitable
            //alternative). Some parts of these games might be tough to write code for, given our current
            //knowledge.For example, the Hangman game would be easier to read a list of words from a
            //file, a topic covered in Level 39.
            //Boss Battle Rock-Paper-Scissors 150 XP
            //The first design pedestal requires you to provide an object-oriented design—a set of objects, classes,
            //and how they interact—for the game of Rock-Paper-Scissors, described below:
            //• Two human players compete against each other.
            //• Each player picks Rock, Paper, or Scissors.
            //194 LEVEL 24 THE CATACOMBS OF THE CLASS
            //• Depending on the players’ choices, a winner is determined: Rock beats Scissors, Scissors beats Paper,
            //Paper beats Rock.If both players pick the same option, it is a draw.
            //• The game must display who won the round.
            //• The game will keep running rounds until the window is closed but must remember the historical
            //record of how many times each player won and how many draws there were.
            //Objectives:
            //• Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to
            //make the game of Rock-Paper-Scissors.You do not need to create this full game; just come up
            //with a potential design as a starting point.

            RockPaperScissors rockPaperScissors = new RockPaperScissors();
            rockPaperScissors.Init();

            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion; 
            

            #region - Challenge7
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge7************");
            Console.WriteLine("*********************************");

            //            Boss Battle 15 - Puzzle 150 XP
            //The second pedestal requires you to provide an object-oriented design for the game of 15 - Puzzle.
            //The game of 15 - Puzzle contains a set of numbered tiles on a board with a single open slot.The goal is to
            //rearrange the tiles to put the numbers in order, with the empty space in the bottom - right corner.
            //• The player needs to be able to manipulate the board to rearrange it.
            //• The current state of the game needs to be displayed to the user.
            //• The game needs to detect when it has been solved and tell the player they won.
            ////• The game needs to be able to generate random puzzles to solve.
            //• The game needs to track and display how many moves the player has made.
            //Objectives:
            //• Use CRC cards(or a suitable alternative) to outline the objects and classes that may be needed to
            //make the game of 15 - Puzzle.You do not need to create this full game; just come up with a
            //potential design as a starting point.
            //• Answer this question: Would your design need to change if we also wanted 3×3 or 5×5 boards?


            Puzzle15Game puzzle15Game = new Puzzle15Game();

            try
            {
                puzzle15Game.Init();

            }
            catch (Exception ex)
            {
                Logger.ExceptionConsole(ex.Message);
            }

            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion; 

            */

            #region - Challenge8
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge8************");
            Console.WriteLine("*********************************");
            //            Boss Battle Hangman 150 XP
            //The third pedestal in this room requires you to provide an object-oriented design for the game of
            //Hangman.In Hangman, the computer picks a random word for the player to guess.The player then
            //proceeds to guess the word by selecting letters from the alphabet, which get filled in, progressively
            //revealing the word.The player can only get so many letters wrong(a letter not found in the word) before
            //losing the game.An example run of this game could look like this:
            //TIC - TAC - TOE 195
            //Word: _ _ _ _ _ _ _ _ _ | Remaining: 5 | Incorrect: | Guess: e
            //Word: _ _ _ _ _ _ _ _ E | Remaining: 5 | Incorrect: | Guess: i
            //Word: I _ _ _ _ _ _ _ E | Remaining: 5 | Incorrect: | Guess: u
            //Word: I _ _ U _ _ _ _ E | Remaining: 5 | Incorrect: | Guess: o
            //Word: I _ _ U _ _ _ _ E | Remaining: 4 | Incorrect: O | Guess: a
            //Word: I _ _ U _ A _ _ E | Remaining: 4 | Incorrect: O | Guess: t
            //Word: I _ _ U T A _ _ E | Remaining: 4 | Incorrect: O | Guess: s
            //Word: I _ _ U T A _ _ E | Remaining: 3 | Incorrect: OS | Guess: r
            //Word: I _ _ U T A _ _ E | Remaining: 2 | Incorrect: OSR | Guess: m
            //Word: I M M U T A _ _ E | Remaining: 2 | Incorrect: OSR | Guess: l
            //Word: I M M U T A _ L E | Remaining: 2 | Incorrect: OSR | Guess: b
            //Word: I M M U T A B L E
            //You won!
            //• The game picks a word at random from a list of words.
            //• The game’s state is displayed to the player, as shown above.
            //• The player can pick a letter.If they pick a letter they already chose, pick again.
            //• The game should update its state based on the letter the player picked.
            //• The game needs to detect a win for the player (all letters have been guessed).
            //• The game needs to detect a loss for the player (out of incorrect guesses).
            //Objectives:
            //• Use CRC cards(or a suitable alternative) to outline the objects and classes that may be needed to
            //make the game of Hangman.You do not need to create this full game; just come up with a
            //potential design as a starting point.

            Hangman hangman = new Hangman();
            hangman.Init();

            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;

            #region - Challenge9
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge9************");
            Console.WriteLine("*********************************");


            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;
        }
    }
}

