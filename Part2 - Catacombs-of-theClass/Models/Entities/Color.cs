using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal class Color
    {
        public byte R { get; set; } = 0;
        public byte G { get; set; } = 0;
        public byte B { get; set; } = 0;

        public Color(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }
        public Color()
        {
            R = 0;
            G = 0;
            B = 0;
        }

        public override string ToString()
        {
            return $"Red: {R}, Green: {G}, Blue: {B}";
        }

        public static Color White => new(255, 255, 255);
        public static Color Black => new(0, 0, 0);
        public static Color Red => new(255, 0, 0);
        public static Color Orange => new(255, 165, 0);
        public static Color Yellow => new(255, 255, 0);
        public static Color Green => new(0, 128, 0);
        public static Color Blue => new(0, 0, 255);
        public static Color Purple => new(128, 0, 128);

    }
}
