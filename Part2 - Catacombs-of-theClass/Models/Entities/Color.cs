using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal class Color
    {
        public byte Red { get; set; } = 0;
        public byte Green { get; set; } = 0;
        public byte Blue { get; set; } = 0;

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public Color()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public string ReadColor()
        {
            return $"Red: {Red}, Green: {Green}, Blue: {Blue}";
        }

        public static Color MakeWhite() => new(255, 255, 255);
        public static Color MakeBlack() => new(0, 0, 0);
        public static Color MakeRed() => new(255, 0, 0);
        public static Color MakeOrange() => new(255, 165, 0);
        public static Color MakeYellow() => new(255, 255, 0);
        public static Color MakeGreen() => new(0, 128, 0);
        public static Color MakeBlue() => new(0, 0, 255);
        public static Color MakePurple() => new(128, 0, 128);

    }
}
