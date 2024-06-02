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
        }
    }
}
