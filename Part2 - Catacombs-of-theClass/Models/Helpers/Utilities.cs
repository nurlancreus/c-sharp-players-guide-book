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
        public static Color? MakeColorAndPrint(string colorName)
        {
            Color color = null;
            switch (colorName.ToLower())
            {
                case "white":
                    color = Color.MakeWhite();
                    break;
                case "black":
                    color = Color.MakeBlack();
                    break;
                case "red":
                    color = Color.MakeRed();
                    break;
                case "orange":
                    color = Color.MakeOrange();
                    break;
                case "yellow":
                    color = Color.MakeYellow();
                    break;
                case "green":
                    color = Color.MakeGreen();
                    break;
                case "blue":
                    color = Color.MakeBlue();
                    break;
                case "purple":
                    color = Color.MakePurple();
                    break;
                default:
                    Console.WriteLine($"Invalid color: {colorName}");
                    break;
            }

            Console.WriteLine($"You chose {colorName} color.");
            Console.WriteLine($"Color: {color?.ReadColor()}");
            return color;
        }
    }
}
