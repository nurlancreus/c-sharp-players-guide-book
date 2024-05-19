using Part2___Catacombs_of_theClass.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Helpers
{
    internal class Utilities
    {
        internal static class EnumReader
        {
            public static T? ReadEnum<T>(string message) where T : struct, Enum
            {
                while (true)
                {
                    Console.Write(message);
                    string? input = Console.ReadLine();

                    if (Enum.TryParse(input, true, out T entity) && Enum.IsDefined(typeof(T), entity)) return entity;
                    else
                        throw new ArgumentException($"Invalid input. Please enter a valid enum value. ({EnumsToString<T>(", ")})");

                }
            }

            static public string EnumsToString<T>(string divider = " ") where T : struct, Enum
            {
                return string.Join(divider, Enum.GetNames(typeof(T)));
            }
        }

        internal static class Colors
        {
            public static Color? MakeColor(string colorName)
            {
                Color? color = null;
                switch (colorName.ToLower())
                {
                    case "white":
                        color = Color.White;
                        break;
                    case "black":
                        color = Color.Black;
                        break;
                    case "red":
                        color = Color.Red;
                        break;
                    case "orange":
                        color = Color.Orange;
                        break;
                    case "yellow":
                        color = Color.Yellow;
                        break;
                    case "green":
                        color = Color.Green;
                        break;
                    case "blue":
                        color = Color.Blue;
                        break;
                    case "purple":
                        color = Color.Purple;
                        break;
                    default:
                        Console.WriteLine($"Invalid color: {colorName}");
                        break;
                }

                return color;
            }
        }

        internal static class ProgramUtils
        {
            public static void ExitProgram(ref bool done, string input = "option")
            {
                Console.WriteLine("invalid {0}.", input);
                Console.WriteLine("Quiting Program..");
                Thread.Sleep(1000);
                done = true;
            }

            public static double ReadNumber(string msg)
            {
                while (true)
                {
                    try
                    {
                        Console.Write(msg);
                        if (Double.TryParse(Console.ReadLine(), out double value)) return value;
                        else throw new FormatException("Your input is not in the correct format");
                    }
                    catch (Exception ex)
                    {
                        Logger.ExceptionConsole(ex.Message);
                    }

                }
            }
        }
    }
}
