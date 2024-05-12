using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using Part2___OOP.Models.Enums;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;
using System.Numerics;
using System.Reflection.Emit;
using Part2___OOP.Helpers;
using Part2___OOP.Models.Classes;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Part2___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Level15 - OOP_BASICS
            Console.WriteLine("**************************");
            Console.WriteLine("**********Level15*********");
            Console.WriteLine("**************************");

            //            Knowledge Check Objects 25 XP
            //Check your knowledge with the following questions:
            //1.What two things does an object bundle together ? - DATA AND OPERATIONS (FIELDS AND METHODS)
            //2.True / False.C# lets you define new types of objects. - TRUE
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");

            #endregion;

            #region Level16 - Enumerations
            Console.WriteLine("**************************");
            Console.WriteLine("**********Level16*********");
            Console.WriteLine("**************************");
            //            Challenge Simula’s Test 100 XP
            //As you move through the village of Enumerant, you notice a short, cloaked figure following you.Not
            //being one to enjoy a mysterious figure tailing you, you seize a moment to confront the figure. “Don’t be
            //alarmed!” she says. “I am Simula.They are saying you’re a Programmer.Is this true ?” You answer in the
            //affirmative, and Simula’s eyes widen. “If you are truly a Programmer, you will be able to help me. Follow
            //me.” She leads you to a backstreet and into a dimly lit hovel. She hands you a small, locked chest. “We
            //haven’t seen any Programmers in these lands in a long time. And especially not ones that can craft types.
            //If you are a True Programmer, you will want what is in that chest. And if you are a True Programmer, I
            //will gladly give it to you to aid you in your quest.”
            //The chest is a small box you can hold in your hand. The lid can be open, closed(but unlocked), or locked.
            //You’d normally be able to go between these states, opening, closing, locking, and unlocking the box, but
            //the box is broken.You need to create a program with an enumeration to recreate this locking mechanism.
            //The image below shows how you can move between the three states:
            //Nothing happens if you attempt an impossible action in the current state, like opening a locked box.
            //The program below shows what using this might look like:
            //            The chest is locked.What do you want to do? unlock
            //            The chest is unlocked.What do you want to do? open
            //            The chest is open.What do you want to do? close
            //            The chest is unlocked.What do you want to do?
            //            Objectives :
            //• Define an enumeration for the state of the chest.
            //• Make a variable whose type is this new enumeration.
            //• Write code to allow you to manipulate the chest with the lock, unlock, open, and close
            //commands, but ensure that you don’t transition between states that don’t support it.
            //• Loop forever, asking for the next command.

            ChestState chestState = ChestState.Locked;

            while (true)
            {

                Console.WriteLine($"Choose between {string.Join(", ", Enum.GetNames(typeof(ChestState)))}. or anything for exit.");
                Console.Write($"The chest is \"{chestState}\". What do you want to do? ");
                if (Enum.TryParse(Console.ReadLine(), out ChestState userChoice))
                {

                    if (chestState == ChestState.Closed)
                    {
                        Console.Clear();
                        if (userChoice == ChestState.Locked)
                        {
                            Console.WriteLine("You locked the chest.");
                            chestState = userChoice;
                        }

                        else if (userChoice == ChestState.Closed || userChoice == ChestState.Unlocked)
                        {
                            Console.WriteLine("Your chest is already unlocked and closed.");
                        }

                        else if (userChoice == ChestState.Open)
                        {
                            Console.WriteLine("You opened the chest");
                            chestState = userChoice;
                        }
                    }

                    else if (chestState == ChestState.Open)
                    {
                        Console.Clear();
                        if (userChoice == ChestState.Closed)
                        {
                            Console.WriteLine("You closed the chest");
                            chestState = userChoice;
                        }

                        else if (userChoice == ChestState.Open || userChoice == ChestState.Unlocked)
                        {
                            Console.WriteLine("Your chest is already unlocked and opened.");
                        }

                        else
                        {
                            Console.WriteLine("You cannot locked the opened chest.");
                        }
                    }

                    else if (chestState == ChestState.Locked)
                    {
                        Console.Clear();
                        if (userChoice == ChestState.Unlocked)
                        {
                            Console.WriteLine("You unlocked the chest.");
                            chestState = userChoice;
                        }
                        else if (userChoice == ChestState.Open)
                        {
                            Console.WriteLine("The chest is locked, you first need to unlock it.");

                        }
                        else if (userChoice == ChestState.Locked || userChoice == ChestState.Closed)
                        {
                            Console.WriteLine("The chest is already closed and locked");
                        }
                    }

                    else if (chestState == ChestState.Unlocked)
                    {
                        Console.Clear();
                        if (userChoice == ChestState.Unlocked || userChoice == ChestState.Closed)
                        {
                            Console.WriteLine("Your chest is already unlocked and closed.");
                        }

                        else if (userChoice == ChestState.Open)
                        {
                            Console.WriteLine("You opened your chest.");
                            chestState = userChoice;
                        }
                        else if (userChoice == ChestState.Locked)
                        {
                            Console.WriteLine("You locked your chest.");
                            chestState = userChoice;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You exit the program...");
                    Thread.Sleep(1000);
                    break;
                };

            }

            #endregion;

            #region Level17 - Tuples
            Console.WriteLine("**************************");
            Console.WriteLine("**********Level17*********");
            Console.WriteLine("**************************");

            //            Challenge Simula’s Soup 100 XP
            //Simula is impressed with how you reconstructed the box with an enumeration. When the box opened,
            //you saw a glowing emerald gem inside. You don’t know what it is, but it seems important. Also in the box
            //were three vials of powder labeled HOT, SALTY, and SWEET.
            //“Finally! I can make soup again!” Simula says. She casually tosses the small glowing gem to you but is
            //wholly focused on the powders. “You stick around and help me make soup with your programming skills,
            //and I’ll tell you what that gem does.”
            //She pulls out a cookpot, knocks the clutter off the table with a quick sweep of her arm, and begins
            //cooking.She says, “I’m the best soup maker in town, and you’re in for a treat. I’ve got recipes for soup,
            //stew, and gumbo.I’ve got mushrooms, chicken, carrots, and potatoes for ingredients.And thanks to you
            //getting that box open, I’ve got seasonings again! Spicy, salty, and sweet seasoning.Pick a recipe, an
            //ingredient, and a seasoning, and I’ll make it.Use your programming skills to help us track what we make.”
            //Objectives:
            //• Define enumerations for the three variations on food: type(soup, stew, gumbo), main ingredient
            //(mushrooms, chicken, carrots, potatoes), and seasoning(spicy, salty, sweet).
            //• Make a tuple variable to represent a soup composed of the three above enumeration types.
            //• Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple
            //with the results.Hint: You could give the user a menu to pick from or simply compare the user’s
            //text input against specific strings to determine which enumeration value represents their choice.
            //• When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
            //Hint: You don’t need to convert the enumeration value back to a string.Simply displaying an
            //enumeration value with Write or WriteLine will display the name of the enumeration value.)

            Console.Write("Choose food type you'd like ({0}): ", Helpers.Helpers.EnumsToString<FoodType>(", "));
            bool isFoodTypeChosen = Enum.TryParse(Console.ReadLine(), out FoodType foodType);

            Console.Write("Choose main ingredient you'd like ({0}): ", Helpers.Helpers.EnumsToString<MainIngredient>(", "));
            bool isMainIngredientChosen = Enum.TryParse(Console.ReadLine(), out MainIngredient mainIngredient);

            Console.Write("Choose seasoning you'd like ({0}): ", Helpers.Helpers.EnumsToString<Seasoning>(", "));
            bool isSeasoningChosen = Enum.TryParse(Console.ReadLine(), out Seasoning seasoning);

            if (isFoodTypeChosen && isMainIngredientChosen && isSeasoningChosen)
            {
                if (Enum.IsDefined<FoodType>(foodType) && Enum.IsDefined<MainIngredient>(mainIngredient) && Enum.IsDefined<Seasoning>(seasoning))
                {
                    (FoodType, MainIngredient, Seasoning) Soup = (FoodType.Stew, MainIngredient.Chicken, Seasoning.Spicy);
                    Console.WriteLine("Your choice is {0}", Soup);
                }
            }
            else Console.WriteLine("Your choices did not parse correctly.");

            #endregion;

            #region Level18 - Classes
            Console.WriteLine("**************************");
            Console.WriteLine("**********Level18*********");
            Console.WriteLine("**************************");

            //            Challenge Vin Fletcher’s Arrows 100 XP
            //     Vin Fletcher is a skilled arrow maker. He asks for your help building a new class to represent arrows and
            //     determine how much he should sell them for. “A tiny fragment of my soul goes into each arrow; I care
            //not for the money; I just need to be able to recoup my costs and get food on the table,” he says.
            //154 LEVEL 18 CLASSES
            //Each arrow has three parts: the arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and
            //100 cm long), and the fletching(plastic, turkey feathers, or goose feathers).
            //His costs are as follows: For arrowheads, steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold.
            //For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold.For the
            //shaft, the price depends on the length: 0.05 gold per centimeter.
            //Objectives:
            //• Define a new Arrow class with fields for arrowhead type, fletching type, and length. (Hint:
            //arrowhead types and fletching types might be good enumerations.)
            //• Allow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.
            //• Add a GetCost method that returns its cost as a float based on the numbers above, and use this
            //to display the arrow’s cost.

            static Arrow? CreateCustomArrow()
            {
                Console.WriteLine("Hi, you are here because you wanted the arrow.");

                Console.Write($"Please, choose the arrow head option you'd like ({Helpers.Helpers.EnumsToString<ArrowHead>(", ")}): ");
                bool isArrowHeadChosen = Enum.TryParse(Console.ReadLine(), true, out ArrowHead arrowHead);

                Console.Write($"Please, choose the fletching option you'd like ({Helpers.Helpers.EnumsToString<Fletching>(", ")}): ");
                bool isFletchingChosen = Enum.TryParse(Console.ReadLine(), true, out Fletching fletching);

                Console.Write($"Please, choose the right shaft length you'd like (60 - 100): ");
                bool isShaftLengthChosen = float.TryParse(Console.ReadLine(), out float shaftLength);

                try
                {
                    if (isArrowHeadChosen && isFletchingChosen && isShaftLengthChosen)
                    {
                        //Arrow arrow = new Arrow(arrowHead, fletching, shaftLength);
                        Arrow arrow = new() { ArrowHead = arrowHead, Fletching = fletching, Shaft = shaftLength };
                        //Console.WriteLine(arrow.DisplayArrow());
                        return arrow;
                    }
                    else
                    {
                        throw new Exception("Your choices did not parse correctly.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }



            #endregion;

            #region Level19 - Information Hiding

            Console.WriteLine("**************************");
            Console.WriteLine("**********Level19*********");
            Console.WriteLine("**************************");

            //            Challenge Vin’s Trouble 50 XP
            //“Master Programmer!” Vin Fletcher shouts at you as he races to catch up to you. “I have a problem. I
            //created an arrow for a young man who took it and changed its length to be half as long as I had designed.
            //It no longer fit in his bow correctly and misfired.It sliced his hand pretty bad.He’ll survive, but is there
            //any way we can make sure somebody doesn’t change an arrow’s length when they walk away from my
            //shop? I don’t want to be the cause of such self - inflicted pain.” With your knowledge of information hiding,
            //you know you can help.
            //Objectives:
            //• Modify your Arrow class to have private instead of public fields.
            //• Add in getter methods for each of the fields that you have.
            #endregion;

            #region Level20 - Properties
            //Console.WriteLine("**************************");
            //Console.WriteLine("**********Level20*********");
            //Console.WriteLine("**************************");

            //Arrow1 arrow1 = GetArrow();
            //Console.WriteLine($"That arrow costs {arrow1.Cost} gold.");



            //Arrow1 GetArrow()
            //{
            //    Arrowhead1 arrowhead1 = GetArrowheadType();
            //    Fletching1 fletching1 = GetFletchingType();
            //    float length = GetLength();

            //    return new Arrow1(arrowhead1, fletching1, length);
            //}

            //Arrowhead1 GetArrowheadType()
            //{
            //    Console.Write("Arrowhead type (steel, wood, obsidian): ");
            //    string input = Console.ReadLine();
            //    return input switch
            //    {
            //        "steel" => Arrowhead1.Steel,
            //        "wood" => Arrowhead1.Wood,
            //        "obsidian" => Arrowhead1.Obsidian
            //    };
            //}

            //Fletching1 GetFletchingType()
            //{
            //    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
            //    string input = Console.ReadLine();
            //    return input switch
            //    {
            //        "plastic" => Fletching1.Plastic,
            //        "turkey feather" => Fletching1.TurkeyFeathers,
            //        "goose feather" => Fletching1.GooseFeathers
            //    };
            //}

            //float GetLength()
            //{
            //    float length = 0;

            //    while (length < 60 || length > 100)
            //    {
            //        Console.Write("Arrow length (between 60 and 100): ");
            //        length = Convert.ToSingle(Console.ReadLine());
            //    }

            //    return length;
            //}

            //Console.WriteLine("**************************");
            //Console.WriteLine("**************************");
            //Console.WriteLine("**************************");

            #endregion;

            #region Level21 - Static
            Console.WriteLine("**************************");
            Console.WriteLine("**********Level21*********");
            Console.WriteLine("**************************");

            //            Challenge Arrow Factories 100 XP
            //Vin Fletcher sometimes makes custom-ordered arrows, but these are rare. Most of the time, he sells one
            //of the following standard arrows:
            //• The Elite Arrow, made from a steel arrowhead, plastic fletching, and a 95 cm shaft.
            //• The Beginner Arrow, made from a wood arrowhead, goose feathers, and a 75 cm shaft.
            //• The Marksman Arrow, made from a steel arrowhead, goose feathers, and a 65 cm shaft.
            //You can make static methods to make these specific variations of arrows easy.
            //Objectives:
            //• Modify your Arrow class one final time to include static methods of the form public static
            //Arrow CreateEliteArrow()
            //        { ... } for each of the three above arrow types.
            //• Modify the program to allow users to choose one of these pre-defined types or a custom arrow.If
            //they select one of the predefined styles, produce an Arrow instance using one of the new static
            //methods.If they choose to make a custom arrow, use your earlier code to get their custom data
            //about the desired arrow.

            Console.WriteLine("\n\n The most saled arrows below: ");

            //Arrow eliteArrow = Arrow.CreateEliteArrow();
            //Console.WriteLine("{0} - {1}", nameof(eliteArrow), eliteArrow.DisplayArrow());

            //Arrow beginnerArrow = Arrow.CreateBeginnerArrow();
            //Console.WriteLine("{0} - {1}", nameof(beginnerArrow), beginnerArrow.DisplayArrow());

            //Arrow marksmanArrow = Arrow.CreateMarksmanArrow();
            //Console.WriteLine("{0} - {1}", nameof(marksmanArrow), marksmanArrow.DisplayArrow());

            Console.WriteLine("What arrow do you want?");
            Console.WriteLine("1 - Elite Arrow");
            Console.WriteLine("2 - Beginner Arrow");
            Console.WriteLine("3 - Marksman Arrow");
            Console.WriteLine("4 - Custom Arrow");


            if (int.TryParse(Console.ReadLine(), out int yourChoice))
            {

                Arrow? arrow = yourChoice switch
                {
                    1 => Arrow.CreateEliteArrow(),
                    2 => Arrow.CreateBeginnerArrow(),
                    3 => Arrow.CreateMarksmanArrow(),
                    _ => CreateCustomArrow(),
                };

                Console.WriteLine(arrow?.DisplayArrow());
            }

            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            #endregion;

            #region Level23 - OOP_DESIGN
            Console.WriteLine("**************************");
            Console.WriteLine("**********Level23*********");
            Console.WriteLine("**************************");

            AsteroidsGame game = new AsteroidsGame();
            game.Run();

            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            #endregion;
        }
        //public class Arrow1
        //{
        //    public Arrowhead1 Arrowhead { get; }
        //    public Fletching1 Fletching { get; }
        //    public float Length { get; }

        //    public Arrow1(Arrowhead1 arrowhead, Fletching1 fletching, float length)
        //    {
        //        Arrowhead = arrowhead;
        //        Fletching = fletching;
        //        Length = length;
        //    }

        //    public float Cost
        //    {
        //        get
        //        {
        //            float arrowheadCost = Arrowhead switch
        //            {
        //                Arrowhead1.Steel => 10,
        //                Arrowhead1.Wood => 3,
        //                Arrowhead1.Obsidian => 5
        //            };

        //            float fletchingCost = Fletching switch
        //            {
        //                Fletching1.Plastic => 10,
        //                Fletching1.TurkeyFeathers => 5,
        //                Fletching1.GooseFeathers => 3
        //            };

        //            float shaftCost = 0.05f * Length;

        //            return arrowheadCost + fletchingCost + shaftCost;
        //        }
        //    }
        //}

        //public enum Arrowhead1 { Steel, Wood, Obsidian }
        //public enum Fletching1 { Plastic, TurkeyFeathers, GooseFeathers }


    }
}

