using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using OOP_part3.Challange1.Entities.BaseModel;
using OOP_part3.Challange1.Entities;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System;
using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using OOP_part3.Challange2;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using OOP_part3.Challenge3;
using System.Drawing;
using System.Text;
using System.Threading;
using OOP_part3.Challenge4;
using SwordR = OOP_part3.Challenge4.Sword;
using static OOP_part3.Program;
using System.Net.NetworkInformation;
using System.Threading.Channels;
using OOP_part3.Challenge5;

namespace OOP_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region-LEVEL25-INHERITENCE
            Console.WriteLine("*********************************");
            Console.WriteLine("*************LEVEL25*************");
            Console.WriteLine("*********************************");

            //            Challenge Packing Inventory 150 XP
            //     You know you have a long, dangerous journey ahead of you to travel to and repair the Fountain of
            //Objects.You decide to build some classes and objects to manage your inventory to prepare for the trip.
            //You decide to create a Pack class to help in holding your items.Each pack has three limits: the total
            //number of items it can hold, the weight it can carry, and the volume it can hold.Each item has a weight
            //and volume, and you must not overload a pack by adding too many items, too much weight, or too much
            //volume.
            //There are many item types that you might add to your inventory, each their own class in the inventory
            //system. (1) An arrow has a weight of 0.1 and a volume of 0.05. (2) A bow has a weight of 1 and a volume
            //of 4. (3) Rope has a weight of 1 and a volume of 1.5. (4) Water has a weight of 2 and a volume of 3. (5) Food
            //rations have a weight of 1 and a volume of 0.5. (6) A sword has a weight of 5 and a volume of 3.
            //Objectives:
            //• Create an InventoryItem class that represents any of the different item types.This class must
            //represent the item’s weight and volume, which it needs at creation time(constructor).
            //• Create derived classes for each of the types of items above.Each class should pass the correct weight
            //and volume to the base class constructor but should be creatable themselves with a parameterless
            //constructor(for example, new Rope() or new Sword()).
            //• Build a Pack class that can store an array of items.The total number of items, the maximum weight,
            //and the maximum volume are provided at creation time and cannot change afterward.
            //• Make a public bool Add(InventoryItem item) method to Pack that allows you to add items
            //of any type to the pack’s contents.This method should fail (return false and not modify the pack’s
            //fields) if adding the item would cause it to exceed the pack’s item, weight, or volume limit.
            //• Add properties to Pack that allow it to report the current item count, weight, and volume, and the
            //limits of each.
            //• Create a program that creates a new pack and then allow the user to add(or attempt to add) items
            //chosen from a menu.

            Console.WriteLine("Welcome to Inheritence level 25 challenge!\n");

            bool isOperationsDone = false;

            Pack pack = new(10, 15, 30);

            while (!isOperationsDone)
            {
                pack.DisplayPack();

                Console.WriteLine(Environment.NewLine);

                foreach (Item item in Enum.GetValues<Item>())
                {
                    Console.Write($"{(int)item} => for ${item}.\n");
                }
                Console.Write($"7 => for showing pack.\n");
                Console.Write($"0 => for Exit.\n");

                try
                {
                    if (!int.TryParse(Console.ReadLine(), out int userChoice))
                    {
                        throw new Exception("Choose correct format data");
                    }

                    switch (userChoice)
                    {
                        case 1:
                            {
                                InventoryItem item = new Arrow();
                                pack.Add(item);
                                break;
                            }
                        case 2:
                            {
                                InventoryItem item = new Bow();
                                pack.Add(item);
                                break;
                            }
                        case 3:
                            {
                                InventoryItem item = new Rope();
                                pack.Add(item);
                                break;
                            }
                        case 4:
                            {
                                InventoryItem item = new Water();
                                pack.Add(item);
                                break;
                            }
                        case 5:
                            {
                                InventoryItem item = new Food();
                                pack.Add(item);
                                break;
                            }
                        case 6:
                            {
                                InventoryItem item = new Sword();
                                pack.Add(item);
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine(pack);
                                break;
                            }
                        case 0:
                            isOperationsDone = true;
                            break;
                        default:
                            throw new Exception("Please enter correct item number...");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }

            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion; 
            */

            /*
            #region-LEVEL26-Polymorphism

            Console.WriteLine("*********************************");
            Console.WriteLine("*************LEVEL26*************");
            Console.WriteLine("*********************************");

            //            Challenge The Old Robot 200 XP
            //You spot something shiny, half - buried in the mud. You pull it out and realize that it seems to be some
            //mechanical automaton with the words “Property of Dynamak” etched into it.As you knock off the cakedon
            //mud, you realize that it seems like this old automaton might even be programmable if you can give it
            //the proper commands. The automaton seems to be structured like this:
            //public class Robot
            //        {
            //            public int X { get; set; }
            //            public int Y { get; set; }
            //            public bool IsPowered { get; set; }
            //            public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
            //            public void Run()
            //            {
            //                foreach (RobotCommand? command in Commands)
            //                {
            //                    command?.Run(this);
            //                    Console.WriteLine($"[{X} {Y} {IsPowered}]");
            //                }
            //            }
            //        }
            //        You don’t see a definition of that RobotCommand class. Still, you think you might be able to recreate it
            //        (a class with only an abstract Run command) and then make derived classes that extend RobotCommand
            //that move it in each of the four directions and power it on and off. (You wish you could manufacture a
            //whole army of these!)
            //Objectives:
            //• Copy the code above into a new project.
            //• Create a RobotCommand class with a public and abstract void Run(Robot robot) method. (The
            //code above should compile after this step.)
            //• Make OnCommand and OffCommand classes that inherit from RobotCommand and turn the robot
            //on or off by overriding the Run method.
            //• Make a NorthCommand, SouthCommand, WestCommand, and EastCommand that move the robot 1
            //unit in the +Y direction, 1 unit in the -Y direction, 1 unit in the -X direction, and 1 unit in the +X
            //direction, respectively. Also, ensure that these commands only work if the robot’s IsPowered
            //property is true.
            //• Make your main method able to collect three commands from the console window. Generate new
            //RobotCommand objects based on the text entered.After filling the robot’s command set with these
            //new RobotCommand objects, use the robot’s Run method to execute them.For example:
            //on
            //north
            //west
            //[0 0 True]
            //[0 1 True]
            //[-1 1 True]
            //• Note: You might find this strategy for making commands that update other objects useful in some
            //of the larger challenges in the coming levels.


            try
            {
                int commandCount = 0;
                Robot robot = new();

                while (commandCount < robot.Commands.Length)
                {
                    Console.WriteLine("Choose command: ");

                    foreach (var commandEnum in Enum.GetValues(typeof(Command)))
                    {
                        Console.WriteLine($"{(int)commandEnum} => {commandEnum}.");
                    }

                    if (int.TryParse(Console.ReadLine(), out int commandNum))
                    {
                        IRobotCommand? command = null;
                        command = commandNum switch
                        {
                            1 => new OnCommand(),
                            2 => new OffCommand(),
                            3 => new NorthCommand(),
                            4 => new SouthCommand(),
                            5 => new EastCommand(),
                            6 => new WestCommand(),
                            _ => throw new Exception("Provide correct format"),
                        };
                        robot.Commands[commandCount] = command;
                        commandCount++;
                    }

                }
                robot.Run();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;
            */


            /*
            #region LEVEL28-Structs
            Console.WriteLine("*********************************");
            Console.WriteLine("*************LEVEL28*************");
            Console.WriteLine("*********************************");

            //            Challenge Room Coordinates 50 XP
            //The time to enter the Fountain of Objects draws closer.While you don’t know what to expect, you have
            //found some scrolls that describe the area in ancient times. It seems to be structured as a set of rooms
            //in a grid-like arrangement.
            ////Locations of the room may be represented as a row and column, and you take it upon yourself to try to
            //capture this concept with a new struct definition.
            //Objectives:
            //• Create a Coordinate struct that can represent a room coordinate with a row and column.

            //• Ensure Coordinate is immutable.
            //• Make a method to determine if one coordinate is adjacent to another (differing only by a single row
            //or column).
            //• Write a main method that creates a few coordinates and determines if they are adjacent to each
            //other to prove that it is working correctly.


            static Coordinate GetCoordinate(string order)
            {
                Console.WriteLine($"Get {order} coordinate's X and Y..");

                Console.Write("X: ");
                if (!int.TryParse(Console.ReadLine(), out int x)) throw new FormatException("The input is not in the correct format");

                Console.Write("Y: ");

                if (!int.TryParse(Console.ReadLine(), out int y)) throw new FormatException("The input is not in the correct format");
                
                return new Coordinate(x, y);

            }

            Coordinate? coord1 = null;
            Coordinate? coord2 = null;

            bool isOperationsDone = false;

            while (!isOperationsDone)
            {
                try
                {
                    Console.WriteLine("Make structs?");

                    if (!char.TryParse(Console.ReadLine(), out char answer)) throw new FormatException("Your input is not in the correct format");

                    if (char.ToLowerInvariant(answer) == 'y')
                    {

                        coord1 ??= GetCoordinate("first");

                        coord2 ??= GetCoordinate("second");

                        if (coord1 is Coordinate c1 && coord2 is Coordinate c2)
                        {
                            isOperationsDone = true;
                            Console.WriteLine("You already define your 2 \"Coordinate\" structs..\nLet's learn if they're adjacent to one another..");

                            if (c1.IsAdjacentTo(c2))
                            {
                                Console.WriteLine($"They're adjacent..\nCoord1's X: {c1.X} and Y: {c1.Y} && Coord2's X: {c2.X} and Y: {c2.Y}");
                            }
                            else
                            {
                                Console.WriteLine($"They're NOT adjacent..\nCoord1's X: {c1.X} and Y: {c1.Y} && Coord2's X: {c2.X} and Y: {c2.Y}");

                            }
                        }


                    }
                    else if (char.ToLowerInvariant(answer) == 'n')
                    {
                        isOperationsDone = true;
                        Console.WriteLine("You exit the program..");
                    }
                    else throw new FormatException("Your input is not in the correct format");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }


            }

            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            #endregion;
            */

            /*
            #region Level29 - Records
            Console.WriteLine("*********************************");
            Console.WriteLine("*************LEVEL29*************");
            Console.WriteLine("*********************************");

            //            Challenge War Preparations 100 XP
            //As you pass through the city of Rocaard, two blacksmiths, Cygnus and Lyra, approach you. “We know
            //where this is headed.A confrontation with the Uncoded One’s forces,” Lyra says. Cygnus continues,
            //“You’re going to need an army at your side—one prepared to do battle.We forge enchanted swords and
            //will do everything we can to support this cause.We need the Power of Programming to flow unfettered
            //too.We want to help, but we can’t equip an entire army without the help of a program to aid in crafting
            //swords.” They describe the program they need, and you dive in to help.
            //Objectives:
            //• Swords can be made out of any of the following materials: wood, bronze, iron, steel, and the rare
            //binarium.Create an enumeration to represent the material type.
            //• Gemstones can be attached to a sword, which gives them strange powers through Cygnus and Lyra’s
            //touch.Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone.Or no
            //gemstone at all.Create an enumeration to represent a gemstone type.
            //• Create a Sword record with a material, gemstone, length, and crossguard width.
            //• In your main program, create a basic Sword instance made out of iron and with no gemstone. Then
            //create two variations on the basic sword using with expressions.
            //• Display all three sword instances with code like Console.WriteLine(original);

            // Get material or gemstone
            static T GetMaterial<T>(string enums) where T : Enum
            {
                Console.WriteLine($"Here are the {enums}: {string.Join(", ", Enum.GetNames(typeof(T)))}\nChoose one:");

                foreach (T item in Enum.GetValues(typeof(T)))
                {
                    Console.WriteLine($"{Convert.ToInt32(item)} for: {item}");
                }

                Console.Write("Your choice: ");
                if (int.TryParse(Console.ReadLine(), out int materialChoice))
                {
                    if (Enum.IsDefined(typeof(T), materialChoice))
                    {
                        return (T)(object)materialChoice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                // Optionally handle the case where input is invalid, here we use recursion for simplicity
                return GetMaterial<T>(enums);
            }

            Console.WriteLine("Welcome to the Blacksmith.\nMake yourself a sword");

            // Get Copy Sword
            static SwordR GetCopySword(string order, SwordR ogSword)
            {
                Console.WriteLine($"Make {order}");

                Console.Write("Add the sword length: ");
                if (!int.TryParse(Console.ReadLine(), out int swordLength)) throw new FormatException("The input is not in the correct format.");


                Console.Write("Add the cross guard width: ");
                if (!int.TryParse(Console.ReadLine(), out int crossWidth)) throw new FormatException("The input is not in the correct format.");


                SwordR copySword = ogSword with
                {
                    Material = GetMaterial<Material>("Materials"),
                    Gemstone = (Gemstone?)GetMaterial<Gemstone>("Gemstones"),
                    Length = swordLength,
                    CrossGuardW = crossWidth
                };

                return copySword;

            }

            bool isOperationsDone = false;

            SwordR? copySword1 = null;
            SwordR? copySword2 = null;

            while (!isOperationsDone)
            {

                try
                {
                    Console.WriteLine("Do you want to make a sword? (y/n)");

                    if (!char.TryParse(Console.ReadLine(), out char answer)) throw new FormatException("The input is not in the correct format. It should be either 'y' or 'n'");

                    if (char.ToLowerInvariant(answer) == 'y')
                    {
                        SwordR ogSword = new(Material.Iron);

                        Console.WriteLine("Do you want to make a copy sword? (y/n)");

                        if (!char.TryParse(Console.ReadLine(), out char a)) throw new FormatException("The input is not in the correct format. It should be either 'y' or 'n'");

                        if (char.ToLowerInvariant(a) == 'y')
                        {
                        
                            copySword1 ??= GetCopySword("First Copy", ogSword);
                            copySword2 ??= GetCopySword("Second Copy", ogSword);

                            if (copySword1 is SwordR sw1 && copySword2 is SwordR sw2)
                            {
                                SwordR[] swords = [ogSword, sw1, sw2];

                                for (int i = 0; i < swords.Length; i++)
                                {
                                    int index = i + 1;

                                    Console.WriteLine($"Sword {(index == 1 ? "Original" : $"Copy {index}")}: {swords[i]}");
                                }
                            }

                            isOperationsDone = true;
                        }
                        else
                        {
                            isOperationsDone = true;
                            Console.WriteLine("Exit the blacksmith");
                        }
                    }
                    else
                    {

                        isOperationsDone = true;
                        Console.WriteLine("Exit the blacksmith");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            #endregion;
            */

            #region Level30 - Generics
            Console.WriteLine("*********************************");
            Console.WriteLine("*************LEVEL30*************");
            Console.WriteLine("*********************************");

            //            Challenge Colored Items 100 XP
            //You have a sword, a bow, and an axe in front of you, defined like this:
            //public class Sword { }
            //        public class Bow { }
            //        public class Axe { }
            //        You want to associate a color with these items(or any item type). You could make ColoredSword
            //derived from Sword that adds a Color property, but doing this for all three item types will be
            //painstaking.Instead, you define a new generic ColoredItem class that does this for any item.
            //Objectives:
            //• Put the three class definitions above into a new project.
            //• Define a generic class to represent a colored item.It must have properties for the item itself (generic
            //in type) and a ConsoleColor associated with it.
            //• Add a void Display() method to your colored item type that changes the console’s foreground
            //color to the item’s color and displays the item in that color. (Hint: It is sufficient to just call
            //ToString() on the item to get a text representation.)
            //• In your main method, create a new colored item containing a blue sword, a red bow, and a green axe.
            //Display all three items to see each item displayed in its color.

            ColoredItem<Challenge5.Sword> sword = new ColoredItem<Challenge5.Sword>(new (), ConsoleColor.Blue);
            ColoredItem<Challenge5.Bow> bow = new ColoredItem<Challenge5.Bow>(new (), ConsoleColor.Red);
            ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

            sword.Display();
            bow.Display();
            axe.Display();

            #endregion;
        }
    }
}
