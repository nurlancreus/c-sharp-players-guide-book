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

namespace Part2___Catacombs_of_theClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            static void ExitProgram(ref bool done, string input = "option")
            {
                Console.WriteLine("invalid {0}.", input);
                Console.WriteLine("Quiting Program..");
                Thread.Sleep(1000);
                done = true;
            }

            bool isOperationsDone = false;

            //static void Utilities.MakeColor(Color? userColor,  string color)
            //{
            //    Console.WriteLine($"You choose {color} color.");
            //    userColor = Color.MakeBlack();
            //    Console.WriteLine($"Color: {userColor?.ReadColor()}");
            //}

            while (!isOperationsDone)
            {
                Console.WriteLine("You either choose to create custom color or make one of most used ones.");
                Console.WriteLine("1.For custom Color.\n2.For White.\n3.For Black.\n4.For Red.\n5.For Orange.\n6.For Yellow.\n7.For Green.\n8.For Blue.\n9.For Purple color.\n0. For exit.");
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
                                Console.WriteLine($"Your custom Color: {userColor?.ReadColor()}");
                            }
                            else
                            {
                                ExitProgram(ref isOperationsDone, "values");

                            }
                            break;

                        case 2:
                            userColor = Utilities.MakeColorAndPrint("White");
                            break;
                        case 3:
                            userColor = Utilities.MakeColorAndPrint("Black");
                            break;
                        case 4:
                            userColor = Utilities.MakeColorAndPrint("Red");
                            break;
                        case 5:
                            userColor = Utilities.MakeColorAndPrint("Orange");
                            break;
                        case 6:
                            userColor = Utilities.MakeColorAndPrint("Yellow");
                            break;
                        case 7:
                            userColor = Utilities.MakeColorAndPrint("Green");
                            break;
                        case 8:
                            userColor = Utilities.MakeColorAndPrint("Blue");
                            break;
                        case 9:
                            userColor = Utilities.MakeColorAndPrint("Purple");
                            break;
                        case 0:
                        default:

                            ExitProgram(ref isOperationsDone);
                            break;
                    }

                }
                else
                {
                    ExitProgram(ref isOperationsDone);

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



            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;


            #region - Challenge4
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge4************");
            Console.WriteLine("*********************************");



            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;


            #region - Challenge5
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("***********Challenge5************");
            Console.WriteLine("*********************************");



            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");

            #endregion;
        }
    }
}
